using System.Text.Json;

namespace Fiss.Tests.Utilities;

public class EnumerableUtilitiesTests
{
    [Fact]
    public void CreateRows_ReturnsCorrectRowData()
    {
        // Arrange
        var people1 = new { Name = @"""John""", Age = "25" };
        var people2 = new { Name = @"""Jane""", Age = "30" };

        var expected = new List<Row>
        {
            new(new Dictionary<string, (string type, string value)>
            {
                { nameof(people1.Name), (JsonValueKind.String.ToString(), value: people1.Name) },
                { nameof(people1.Age), (JsonValueKind.Number.ToString(), value: people1.Age) }
            }),
            new(new Dictionary<string, (string type, string value)>
            {
                { nameof(people2.Name), (JsonValueKind.String.ToString(), value: people2.Name) },
                { nameof(people2.Age), (JsonValueKind.Number.ToString(), value: people2.Age) }
            })
        };

        var data = new List<List<JsonElement?>>
        {
            new() { JsonDocument.Parse(people1.Name).RootElement, JsonDocument.Parse(people1.Age).RootElement },
            new() { JsonDocument.Parse(people2.Name).RootElement, JsonDocument.Parse(people2.Age).RootElement }
        };
        var columns = new List<Header?>
        {
            new(nameof(people1.Name)),
            new(nameof(people2.Age))
        };

        // Act
        var actual = EnumerableUtilities.CreateRows(data, columns);

        // Assert
        Assert.Equal(2, actual.Count);
        Assert.Equal(expected, actual, RowComparer.Instance);
    }

    [Fact]
    public void CreateRows_EmptyData()
    {
        // Arrange
        var data = new List<List<JsonElement?>>();
        var columns = new List<Header?>
        {
            new(string.Empty),
            new(string.Empty)
        };

        // Act
        var actual = EnumerableUtilities.CreateRows(data, columns);

        // Assert
        Assert.Empty(actual);
    }

    [Fact]
    public void CreateRows_InvalidOperationException()
    {
        // Arrange
        var people1 = new { Name = @"""John""", Age = "25" };
        var people2 = new { Name = @"""Jane""", Age = "30" };

        var data = new List<List<JsonElement?>>
        {
            new() { JsonDocument.Parse(people1.Name).RootElement, JsonDocument.Parse(people1.Age).RootElement },
            new() { JsonDocument.Parse(people2.Name).RootElement, JsonDocument.Parse(people2.Age).RootElement }
        };

        // Act

        // Assert
        Assert.Throws<InvalidOperationException>(() => EnumerableUtilities.CreateRows(data, new List<Header?>()));
    }

    private class RowComparer : IEqualityComparer<Row>
    {
        public static readonly RowComparer Instance = new();

        public bool Equals(Row? current, Row? other)
        {
            if (current == null) return false;
            if (other == null) return false;

            if (ReferenceEquals(current, other)) return true;

            return current.Cells.Count == other.Cells.Count &&
                   current.Cells.Keys.All(key => other.Cells.ContainsKey(key) &&
                                                 other.Cells[key].Equals(current.Cells[key]));
        }

        public int GetHashCode(Row obj)
        {
            return obj.GetHashCode();
        }
    }
}
