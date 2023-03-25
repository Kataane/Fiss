namespace Fiss;

/// <summary>
///     Represents a query operator that is used to add queries to a URL.
/// </summary>
internal ref struct QueryOperator
{
    /// <summary>
    ///     Adds queries to a URL.
    /// </summary>
    /// <param name="initialBuffer">The initial buffer to use.</param>
    /// <param name="url">The URL to add queries to.</param>
    /// <param name="queries">The queries to add to the URL.</param>
    /// <returns>The URL with the added queries.</returns>
    public static string AddQuery(
        Span<char> initialBuffer, string url,
        IEnumerable<KeyValuePair<string, string>> queries)
    {
        ArgumentException.ThrowIfNullOrEmpty(url);

        var pairs = queries.ToList();
        if (!pairs.Any()) throw new ArgumentNullException(nameof(queries));

        var pos = url.Length;
        url.AsSpan().CopyTo(initialBuffer);

        // Url dont have any query
        if (initialBuffer.IndexOf(Constants.Question) == -1)
        {
            InitQueries(ref initialBuffer, pairs, ref pos);
            goto @return;
        }

        foreach (var query in pairs)
        {
            var fullQuery = query.Key + Constants.Equals + query.Value;
            UpdateQuery(ref initialBuffer, fullQuery, query.Key, ref pos);
        }

        @return:
        return initialBuffer.Slice(0, pos).ToString();
    }

    /// <summary>
    ///     Initializes queries for a URL.
    /// </summary>
    /// <param name="initialBuffer">The initial buffer to use.</param>
    /// <param name="queries">The queries to add to the URL.</param>
    /// <param name="pos">The position of the URL in the buffer.</param>
    private static void InitQueries(
        ref Span<char> initialBuffer,
        IReadOnlyCollection<KeyValuePair<string, string>> queries,
        ref int pos)
    {
        initialBuffer[pos++] = Constants.Question;
        var addAmpersand = false;

        for (var i = 0; i < queries.Count; i++)
        {
            var query = queries.ElementAt(i);
            var fullQuery = query.Key + Constants.Equals + query.Value;
            AddQueryCore(ref initialBuffer, fullQuery, ref pos, addAmpersand);

            if (i == 0) addAmpersand = true;
        }
    }

    /// <summary>
    ///     Adds a query to a URL.
    /// </summary>
    /// <param name="pool">The buffer to add the query to.</param>
    /// <param name="query">The query to add to the buffer.</param>
    /// <param name="pos">The position of the buffer to add the query to.</param>
    /// <param name="addAmpersand">A value indicating whether to add an ampersand to the buffer before adding the query.</param>
    private static void AddQueryCore(
        ref Span<char> pool,
        ReadOnlySpan<char> query,
        ref int pos,
        bool addAmpersand = true)
    {
        if (addAmpersand) pool[pos++] = Constants.Ampersand;
        query.CopyTo(pool.Slice(pos));
        pos += query.Length;
    }

    /// <summary>
    ///     Updates a query in a URL.
    /// </summary>
    /// <param name="chars">The buffer containing the URL.</param>
    /// <param name="query">The query to update in the URL.</param>
    /// <param name="queryName">The name of the query to update in the URL.</param>
    /// <param name="pos">The position of the URL in the buffer.</param>
    /// <param name="skipIfQueryExist">A value indicating whether to skip updating the query if it already exists in the URL.</param>
    private static void UpdateQuery(
        ref Span<char> chars,
        ReadOnlySpan<char> query,
        ReadOnlySpan<char> queryName,
        ref int pos, bool skipIfQueryExist = true)
    {
        ReadOnlySpan<char> readOnlyChars = chars;
        var queryStartIndex = readOnlyChars.IndexOf(queryName, StringComparison.OrdinalIgnoreCase);

        if (queryStartIndex == -1)
        {
            goto addQuery;
        }

        var existedQueryLength = readOnlyChars.Slice(queryStartIndex).IndexOf(Constants.Ampersand);
        if (existedQueryLength == -1) existedQueryLength = pos - queryStartIndex;

        if (skipIfQueryExist)
        {
            var querySame = readOnlyChars.Slice(queryStartIndex, existedQueryLength)
                .Equals(query, StringComparison.OrdinalIgnoreCase);
            if (querySame) return;
        }

        pos = pos - existedQueryLength - 1;

        readOnlyChars.Slice(queryStartIndex + existedQueryLength + 1).CopyTo(chars.Slice(queryStartIndex));

        addQuery:
        AddQueryCore(ref chars, query, ref pos);
    }
}