namespace Fiss.Tests;

public class Queries : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("Test", "test"),
                    new("Test2", "test2")
                },
                Format.Json,
                "https://iss.moex.com/iss.json?Test=test&Test2=test2")
        };

        yield return new object[]
        {
            (new List<KeyValuePair<string, string>>
                {
                    new("Test", "test"),
                    new("Test2", "test2")
                },
                Format.Xml,
                "https://iss.moex.com/iss.xml?Test=test&Test2=test2")
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}