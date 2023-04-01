#pragma warning disable CS8625

using System.Net;
using Moq.Protected;

namespace Fiss.Tests;

public partial class PagedCursorTest
{
    private const string baseUrl = "https://iss.moex.com/iss.json";
    private readonly Mock<IHttpContentSerializer> httpContentSerializerMock = new();
    private readonly Mock<HttpMessageHandler> handlerMock = new();
    private const string httpMessageHandlerSendAsyncMethodName = "SendAsync";

    [Fact]
    public void Constructor_IndexMoreThanTotal_ThrowArgumentException()
    {
        // Arrange

        // Act

        // Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            new PagedCursor<string>(2600, 2500, PageSize.Hundred, baseUrl, httpContentSerializerMock.Object));
        Assert.Equal("The index value 2600 cannot be more than total value 2500. (Parameter 'index')", exception.Message);
    }

    [Theory]
    [InlineData(0, 100, PageSize.Hundred)]
    public void Constructor_UrlLengthMore512_ThrowArgumentException(int index, int total, PageSize pageSize)
    {
        // Arrange
        var url = string.Join(string.Empty, Enumerable.Repeat("n", 512));
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
            new PagedCursor<string>(-1, 2500, PageSize.Hundred, baseUrl, httpContentSerializerMock.Object));
        var exception2 = Assert.Throws<ArgumentOutOfRangeException>(() =>
            new PagedCursor<string>(10, -1, PageSize.Hundred, baseUrl, httpContentSerializerMock.Object));

        Assert.Equal("The index value cannot be less than 0. (Parameter 'index')", exception1.Message);
        Assert.Equal("The total value cannot be less than 0. (Parameter 'total')", exception2.Message);
    }

    [Fact]
    public void Constructor_UrlIsNullOrEmpty_ThrowArgumentException()
    {
        // Arrange

        // Act
        PagedCursor<string> CreatePageCursorFunc(string url)
        {
            return new PagedCursor<string>(0, 2500, PageSize.Hundred, url, httpContentSerializerMock.Object);
        }

        // Assert
        Assert.Throws<ArgumentException>(() => CreatePageCursorFunc(string.Empty));
        Assert.Throws<ArgumentNullException>(() => CreatePageCursorFunc(null));
    }

    [Theory]
    [InlineData(0, 100, PageSize.Hundred)]
    [InlineData(1, 73, PageSize.Ten)]
    [InlineData(5, 100, PageSize.Twenty)]
    [InlineData(100, 100, PageSize.Hundred)]
    public void TryNext_UpdateStartQueryUseTryNext_ReturnsUpdatedStartQuery(int index, int total, PageSize pageSize)
    {
        // Arrange
        var pageSizeI = (int)pageSize;
        var expected = new List<string> { baseUrl + $"?limit={pageSizeI}&start={index}" };
        var i = index;
        while (total > i + pageSizeI)
        {
            i += pageSizeI;
            expected.Add(baseUrl + $"?limit={pageSizeI}&start={i}");
        }

        // Act
        var cursor = new PagedCursor<string>(index, total, pageSize, baseUrl, httpContentSerializerMock.Object);
        var actual = new List<string>();
        do
        {
            actual.Add(cursor.ToString());
        } while (cursor.TryNext());

        // Assert
        Assert.Equal(expected.Count, actual.Count);
        Assert.All(expected.Zip(actual, (exp, act) => (exp, act)), tuple =>
        {
            var (exp, act) = tuple;
            Assert.True(Uri.IsWellFormedUriString(act, UriKind.Absolute));
            Assert.Equal(exp, act);
        });
    }

    [Theory]
    [ClassData(typeof(PageCursorData))]
    public void ToString_IssRequestWithSameStartAndLimit_QueryUntouched(
        (List<KeyValuePair<string, string>> queries, int start, PageSize pageSize, string expected) parameters)
    {
        // Arrange
        var uriFromIssRequest =
            new Uri(QueryHelpers.AddQueryString(baseUrl,
                parameters.queries.ToDictionary(kvp => kvp.Key, kvp => kvp.Value))).AbsoluteUri;

        // Act
        var cursor = new PagedCursor<string>(parameters.start, (int)parameters.pageSize, PageSize.Hundred,
            uriFromIssRequest, httpContentSerializerMock.Object);
        var str = cursor.ToString();

        // Assert
        Assert.True(Uri.IsWellFormedUriString(str, UriKind.Absolute));
        Assert.Equal(parameters.expected, str);
    }
}

public partial class PagedCursorTest
{
    [Fact]
    public void TryToPage_WhenTotalIsZero_ReturnsFalse()
    {
        // Arrange
        var cursor = new PagedCursor<object>(0, 0, PageSize.Ten, baseUrl, httpContentSerializerMock.Object);

        // Act
        var result = cursor.TryToPage(1);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void TryToPage_WhenPageIsNegative_ReturnsFalse()
    {
        // Arrange
        var cursor = new PagedCursor<object>(0, 10, PageSize.Ten, baseUrl, httpContentSerializerMock.Object);

        // Act
        var result = cursor.TryToPage(-1);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void TryToPage_WhenPageIsGreaterThanCountPages_ReturnsFalse()
    {
        // Arrange
        var cursor = new PagedCursor<object>(0, 10, PageSize.Ten, baseUrl, httpContentSerializerMock.Object);

        // Act
        var result = cursor.TryToPage(2);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void TryToPage_WhenPageIsValid_ReturnsTrue()
    {
        // Arrange
        var cursor = new PagedCursor<object>(0, 20, PageSize.Ten, baseUrl, httpContentSerializerMock.Object);

        // Act
        var result = cursor.TryToPage(1);

        // Assert
        Assert.True(result);
    }
}

public partial class PagedCursorTest
{
    [Fact]
    public async Task GetAsyncEnumerator_PassMessageHandlerWithEntities_ReturnsAllEntities()
    {
        // Arrange
        var expectedEntities = new[] { "entity1", "entity2", "entity3" };

        var call = -1;
        httpContentSerializerMock.Setup(s => s.Deserialize<string>(It.IsAny<HttpContent>(), It.IsAny<CancellationToken>()))
            .Callback(() => { call++; })
            .ReturnsAsync(() => expectedEntities[call]);

        var httpClient = new HttpClient();
        var cursor = new PagedCursor<string>(0, expectedEntities.Length, PageSize.One, baseUrl, httpContentSerializerMock.Object, httpClient);

        // Act
        var actual = new List<string>();
        await foreach (var entity in cursor)
        {
            actual.Add(entity);
        }

        // Assert
        Assert.Equal(expectedEntities, actual);

        httpContentSerializerMock.Verify(
            s => s.Deserialize<string>(
                It.IsAny<HttpContent>(),
                It.IsAny<CancellationToken>()),
            Times.Exactly(3));
    }

    [Fact]
    public async Task GetAsyncEnumerator_TotalEqualsZero_ReturnsEmpty()
    {
        // Arrange
        var expectedEntities = new[] { "entity1", "entity2", "entity3" };

        var call = -1;
        httpContentSerializerMock.Setup(s => s.Deserialize<string>(It.IsAny<StringContent>(), It.IsAny<CancellationToken>()))
            .Callback(() => call++)
            .ReturnsAsync(() => expectedEntities[call]);

        var httpClient = new HttpClient();
        var cursor = new PagedCursor<string>(0, 0, PageSize.One, baseUrl, httpContentSerializerMock.Object, httpClient);

        // Act
        var actual = new List<string>();
        await foreach (var entity in cursor)
        {
            actual.Add(entity);
        }

        // Assert
        Assert.Equal(Enumerable.Empty<string>(), actual);

        httpContentSerializerMock.Verify(
            s => s.Deserialize<string>(
                It.IsAny<StringContent>(),
                It.IsAny<CancellationToken>()),
            Times.Never);
    }

    [Fact]
    public async Task GetAsyncEnumerator_GetPageResultReturnNull_ThrowArgumentNullException()
    {
        // Arrange
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(httpMessageHandlerSendAsyncMethodName, ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(() => new HttpResponseMessage(HttpStatusCode.OK));

        httpContentSerializerMock.Setup(s => s.Deserialize<string>(It.IsAny<StringContent>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(() => null);

        var httpClient = new HttpClient(handlerMock.Object);
        var cursor = new PagedCursor<string>(0, 1, PageSize.One, baseUrl, httpContentSerializerMock.Object, httpClient);

        // Act

        // Assert
        await Assert.ThrowsAsync<ArgumentNullException>(async () =>
        {
            await foreach (var _ in cursor)
            {
            }
        });
    }
}

public partial class PagedCursorTest
{
    [Fact]
    public async Task GetPageResult_HttpResponseMessageOkAndSerializerReturnValidEntity_ReturnSerializedEntity()
    {
        // Arrange
        const string expectedEntity = "entity1";

        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(httpMessageHandlerSendAsyncMethodName, ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(() => new HttpResponseMessage(HttpStatusCode.OK));

        httpContentSerializerMock.Setup(s => s.Deserialize<string>(It.IsAny<HttpContent>(), It.IsAny<CancellationToken>())).ReturnsAsync(() => expectedEntity);

        var httpClient = new HttpClient(handlerMock.Object);
        var cursor = new PagedCursor<string>(0, 1, PageSize.One, baseUrl, httpContentSerializerMock.Object, httpClient);

        // Act
        var actual = await cursor.GetPageResult();

        // Assert
        Assert.Equal(expectedEntity, actual);

        handlerMock.Protected().Verify(
            httpMessageHandlerSendAsyncMethodName,
            Times.Once(),
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>()
        );
        httpContentSerializerMock.Verify(
            s => s.Deserialize<string>(
                It.IsAny<HttpContent>(),
                It.IsAny<CancellationToken>()),
            Times.Once);
    }

    [Fact]
    public async Task GetPageResult_HttpResponseMessageNotOk_ThrowHttpRequestException()
    {
        // Arrange
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(httpMessageHandlerSendAsyncMethodName, ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(() => new HttpResponseMessage(HttpStatusCode.NotFound));

        var httpClient = new HttpClient(handlerMock.Object);
        var cursor = new PagedCursor<string>(0, 1, PageSize.One, baseUrl, httpContentSerializerMock.Object, httpClient);

        // Act

        // Assert
        await Assert.ThrowsAsync<HttpRequestException>(async () => await cursor.GetPageResult());

        handlerMock.Protected().Verify(
            httpMessageHandlerSendAsyncMethodName,
            Times.Once(),
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>()
        );
        httpContentSerializerMock.Verify(
            s => s.Deserialize<string>(
                It.IsAny<HttpContent>(),
                It.IsAny<CancellationToken>()),
            Times.Never);
    }

    [Fact]
    public async Task GetPageResult_TotalEqualZero_ReturnDefault()
    {
        // Arrange
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(httpMessageHandlerSendAsyncMethodName, ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(() => new HttpResponseMessage(HttpStatusCode.OK));

        var httpClient = new HttpClient(handlerMock.Object);
        var cursor = new PagedCursor<string>(0, 0, PageSize.One, baseUrl, httpContentSerializerMock.Object, httpClient);

        // Act
        var actual = await cursor.GetPageResult();

        // Assert
        Assert.Equal(default, actual);

        handlerMock.Protected().Verify(
            httpMessageHandlerSendAsyncMethodName,
            Times.Never(),
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>()
        );
        httpContentSerializerMock.Verify(
            s => s.Deserialize<string>(
                It.IsAny<HttpContent>(),
                It.IsAny<CancellationToken>()),
            Times.Never);
    }
}
