namespace Fiss.Tests;

public class PageCursorCtor
{
    public const string BaseUrl = "https://iss.moex.com/iss.json";
    private readonly Mock<IHttpContentSerializer> httpContentSerializerMock = new();

    [Fact]
    public void Constructor_IndexMoreThanTotal_ThrowArgumentException()
    {
        // Arrange

        // Act

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            new PagedCursor<string>(2600, 2500, PageSize.Hundred, BaseUrl, httpContentSerializerMock.Object));
        Assert.Equal("The index value 2600 cannot be more than total value 2500. (Parameter 'index')", exception.Message);
    }

    [Theory]
    [InlineData(0, 100, PageSize.Hundred)]
    public void Constructor_UrlLengthMore512_ThrowArgumentException(int index, int total, PageSize pageSize)
    {
        // Arrange
        var url = string.Join("", Enumerable.Repeat("n", 512));
        var limitQuerySize = Constants.LimitQuerySize + ((int)pageSize).ToString().Length;
        var startQuerySize = Constants.StartQuerySize + total.ToString().Length;
        var finalUrlLength = url.Length + limitQuerySize + startQuerySize;

        // Act

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            new PagedCursor<string>(index, total, pageSize, url, httpContentSerializerMock.Object));
        Assert.Equal($"The size value {finalUrlLength} cannot be more than maxSizeForStackAlloc value 512. (Parameter 'size')",
            exception.Message);
    }

    [Fact]
    public void Constructor_IndexOrTotalLessZero_ThrowArgumentException()
    {
        // Arrange

        // Act

        // Assert
        var exception1 = Assert.Throws<ArgumentOutOfRangeException>(() =>
            new PagedCursor<string>(-1, 2500, PageSize.Hundred, BaseUrl, httpContentSerializerMock.Object));
        var exception2 = Assert.Throws<ArgumentOutOfRangeException>(() =>
            new PagedCursor<string>(10, -1, PageSize.Hundred, BaseUrl, httpContentSerializerMock.Object));

        Assert.Equal("The index value cannot be less than 0. (Parameter 'index')", exception1.Message);
        Assert.Equal("The total value cannot be less than 0. (Parameter 'total')", exception2.Message);
    }
}