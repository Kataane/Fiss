namespace Fiss.Extensions;

/// <summary>
/// Статическая обертка для IIssRequst 
/// для создания цепочки обязанностей.
/// В данном классе реализованны базовые операции.
/// </summary>
/// <example>
/// <code>
/// var requst = new IssRequest().Path("bondization");
/// </code>
/// </example>
public static class IssRequestExtension
{
    public static string Json { get; private set; }

    /// <summary>
    /// Преобразует полный путь запроса в массив путей.
    /// Добавляя его в общий массив путей.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="path">Пути разделенные косой чертой.</param>
    /// <example>
    /// <code>
    /// var path = "statistics/engines/stock/markets";
    /// new IssRequest().FullPath(path);
    /// </code>
    /// </example>
    public static IIssRequest FullPath(this IIssRequest request, string path)
    {
        var paths = path.Split('/').ToArray();
        request.AddPaths(paths);
        return request;
    }

    /// <summary>
    /// Преобразует полный путь запроса в массив путей.
    /// Добавляя его в общий массив путей.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="path">Пути разделенные косой чертой.</param>
    /// <param name="params"></param>
    /// <example>
    /// <code>
    /// var path = "statistics/engines/[engine]/markets";
    /// new IssRequest().FullPath(path);
    /// </code>
    /// </example>
    public static IIssRequest FullPath(this IIssRequest request, string path, string[] @params)
    {
        const string closedBrackets = @"^([^[\]]*\[[^[\]]*\]){0,3}[^[\]]*$";
        if (!Regex.IsMatch(path, closedBrackets)) throw new Exception("Path not valid");

        var paths = TransformPath(path, @params);
        request.AddPaths(paths);

        return request;
    }

    /// <summary>
    /// Добавляет путь/пути в общий массив путей.
    /// </summary>
    public static IIssRequest Path(this IIssRequest request, params string[] paths)
    {
        request.AddPaths(paths);
        return request;
    }
    public static IIssRequest QueryConvert(this IIssRequest request, IssQueryWrap issQueryWrap)
    {
        request.FullPath(issQueryWrap.Path, issQueryWrap.Params);
        request.AddQueries(issQueryWrap.Queries);

        return request;
    }

    public static IIssRequest QueryConvert(this IIssRequest request, IssQueryWrap issQueryWrap, string[] @params)
    {
        if (@params.Any()) request.FullPath(issQueryWrap.Path, @params);
        else request.FullPath(issQueryWrap.Path);

        if (issQueryWrap.Queries is not null && 
            issQueryWrap.Queries.Any()) 
            request.AddQueries(issQueryWrap.Queries);

        return request;
    }

    public static IIssRequest Extension(this IIssRequest request, Extension extension)
    {
        request.ChangeExtension(extension);
        return request;
    }

    public static async Task<IIssRequest> Fetch(this IIssRequest request)
    {
        var url = ConstructUrl(request);

        using HttpClient client = new(new HttpClientHandler
        {
            MaxConnectionsPerServer = 100,
        });

        Json = await client.GetStringAsync(url);

        return request;
    }

    /// <summary>
    /// Предоставляет возможность пагинации
    /// по ответаам от ISS Moex
    /// </summary>
    public static CursorRequest<IDictionary<string, Table>> ToCursor(this IIssRequest request,
        string cursorTitle = "",
        int index = 0,
        PageSize pageSize = PageSize.Twenty)
    {
        return request.ToCursor(ToResponse, Fetch, cursorTitle, index, pageSize);
    }

    /// <summary>
    /// Предоставляет возможность пагинации
    /// по ответаам от ISS Moex
    /// </summary>
    /// <param name="request"></param>
    /// <param name="converter"></param>
    /// <param name="fetch"></param>
    /// <param name="cursorTitle"></param>
    /// <param name="index"></param>
    /// <param name="pageSize"></param>
    public static CursorRequest<TResult> ToCursor<TResult>(this IIssRequest request,
        Func<IIssRequest, TResult> converter,
        Func<IIssRequest, Task<IIssRequest>> fetch,
        string cursorTitle = "", 
        int index = 0, 
        PageSize pageSize = PageSize.Hundred)
    {
        var header = cursorTitle + ".cursor";

        var cursors = request.ToResponse()
            .Where(kvp => kvp.Key.ContainsWithIgnoreCase(header));

        var totals = cursors.SelectMany(t => t.Value.Rows
            .SelectMany(r => r.Values.SelectWhere(
                v => v.Value,
                    v => v.Key.Equals("Total"))));

        var max = totals.Cast<long>()
            .OrderByDescending(i => i).FirstOrDefault(0L);

        return new CursorRequest<TResult>(request, index, max, pageSize, converter, fetch);
    }

    // Десереализации ответа в кастомный ответ
    // Благодаря аттрибуту [JsonConverter]
    /// <summary>
    /// Преобразует ответ от ISS Moex в указанный тип.
    /// </summary>
    public static T ToResponse<T>(this IIssRequest _)
    {
        return string.IsNullOrEmpty(Json) ? default : JsonConvert.DeserializeObject<T>(Json);
    }

    /// <summary>
    /// Преобразует ответ от ISS Moex в
    /// <see>
    ///     <cref>IDictionary{string, Table}</cref>
    /// </see>
    /// . 
    /// </summary>
    public static IDictionary<string, Table> ToResponse(this IIssRequest request) =>
        request.ToResponse<IssResponse>().Tables;

    /// <summary>
    /// Преобразует ответ основой которого является <see cref="IssResponse"/> 
    /// от ISS Moex в динамический объект.
    /// </summary>
    public static dynamic ToDynamic(this IIssRequest request)
    {
        var response = request.ToResponse();

        dynamic tables = new ExpandoObject();
        var dictionary = tables as IDictionary<string, object>;

        foreach (var (name, table) in response)
        {
            dynamic @object = new ExpandoObject();
            @object.Columns = table.Headers;

            @object.Rows = table.Rows.Select(row =>
            {
                dynamic values = new ExpandoObject();
                var prop = values as IDictionary<string, object>;
                _ = row.Values.ToLookup(item => prop[item.Key] = item.Value);

                return values;
            }).ToList();

            dictionary[name] = @object;
        }

        return tables;
    }

    /// <summary>
    /// Собирает из 
    /// <see cref="IIssRequest.Host"/>, 
    /// <see cref="IIssRequest.Paths"/>,
    /// <see cref="IIssRequest.Extension"/>,
    /// <see cref="IIssRequest.Queries"/>
    /// полноценный URL.
    /// </summary>
    private static string ConstructUrl(IIssRequest request)
    {
        var fullQuery = "?" + string.Join("&", request.Queries
            .Select(query => $"{query.Key}={query.Value}"));

        return request.Host + string.Join("/", request.Paths) + request.Extension + fullQuery;
    }

    private static IEnumerable<string> TransformPath(string url, string[] @params)
    {
        const string closedBrackets = @"\[([^]]*)\]";

        var paths = url.Split('/').ToList();
        var count = paths.Count(path => Regex.IsMatch(path, closedBrackets));

        if (count == 0) return paths;
        if (@params is null || @params.Length != count) throw new Exception("Where params?");

        for (var i = 0; i < paths.Count; i++)
        {
            if (!Regex.IsMatch(paths[i], closedBrackets)) continue;

            var parameter = @params[0];
            @params = @params.Skip(1).ToArray();

            paths[i] = parameter;
        }

        return paths;
    }
}
