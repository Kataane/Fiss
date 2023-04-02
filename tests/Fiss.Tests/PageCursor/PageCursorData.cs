namespace Fiss.Tests;

public class PageCursorData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        // Dont touch limit because it is correct and static
        // Move start to end because it can change.
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("Test", "test"),
                    new("limit", "100"),
                    new("start", "100"),
                    new("Test2", "test2")
                },
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?Test=test&limit=100&Test2=test2&start=100")
        };

        // Replace invalid limit=50 to limit=100 and move to end
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("Test", "test"),
                    new("limit", "50"),
                    new("Test2", "test2")
                },
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?Test=test&Test2=test2&limit=100&start=100")
        };

        // Replace invalid limit=50 to limit=100 from start and move to end
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("limit", "50"),
                    new("Test", "test"),
                    new("Test2", "test2")
                },
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?Test=test&Test2=test2&limit=100&start=100")
        };

        // Replace invalid limit=50 to limit=100 from end and move to end
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("Test", "test"),
                    new("Test2", "test2"),
                    new("limit", "50"),
                },
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?Test=test&Test2=test2&limit=100&start=100")
        };

        // Add queries limit=100&start=100 to end
        yield return new object[]
        {
            (Enumerable.Empty<KeyValuePair<string, string>>().ToList(),
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?limit=100&start=100")
        };

        // Add queries limit=100&start=100 to end
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("Test", "test"),
                    new("Test2", "test2")
                },
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?Test=test&Test2=test2&limit=100&start=100")
        };

        // Replace invalid start=5 to start=100 and move to end
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("Test", "test"),
                    new("start", "5"),
                    new("Test2", "test2")
                },
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?Test=test&Test2=test2&limit=100&start=100")
        };

        // Replace invalid start=5 to start=100 from start and move to end
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("start", "5"),
                    new("Test", "test"),
                    new("Test2", "test2")
                },
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?Test=test&Test2=test2&limit=100&start=100")
        };

        // Replace invalid start=5 to start=100 from start and move to end
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("Test", "test"),
                    new("Test2", "test2"),
                    new("Test3", "test3"),
                    new("start", "5"),
                },
                100,
                PageSize.Hundred,
                "https://iss.moex.com/iss.json?Test=test&Test2=test2&Test3=test3&limit=100&start=100")
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}