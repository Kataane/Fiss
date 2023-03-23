namespace Fiss;

internal ref struct QueryOperator
{
    public static string AddQuery(
        Span<char> initialBuffer, string? url,
        IEnumerable<KeyValuePair<string, string>> queries)
    {
        var pairs = queries.ToList();
        if (!pairs.Any()) throw new ArgumentNullException(nameof(queries));

        var pos = url.Length;
        url.AsSpan().CopyTo(initialBuffer);

        // Url dont have any query
        if (initialBuffer.IndexOf(Constants.Question) == -1)
        {
            InitQueries(ref initialBuffer, pairs.ToList(), ref pos);
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

    private static void InitQueries(ref Span<char> initialBuffer,
        IReadOnlyCollection<KeyValuePair<string, string>> queries, ref int pos)
    {
        initialBuffer[pos++] = Constants.Question;
        var addAmpersand = false;

        for (var i = 0; i < queries.Count; i++)
        {
            var query = queries.ElementAt(i);
            var fullQuery = query.Key + Constants.Equals + query.Value;
            AddQuery(ref initialBuffer, fullQuery, ref pos, addAmpersand);

            if (i == 0) addAmpersand = true;
        }
    }

    private static void AddQuery(ref Span<char> pool, ReadOnlySpan<char> query, ref int pos, bool addAmpersand = true)
    {
        if (addAmpersand) pool[pos++] = Constants.Ampersand;
        query.CopyTo(pool.Slice(pos));
        pos += query.Length;
    }

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
        AddQuery(ref chars, query, ref pos);
    }
}