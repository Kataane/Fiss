namespace Fiss.Tests;

public partial class IssRequestTest
{
    private const string baseUrl = "https://iss.moex.com/iss/";
    private const string baseUrlWithoutSlash = "https://iss.moex.com/iss";

    [Fact]
    public void Constructor_DefaultIssRequest()
    {
        // Arrange
        const string expected = baseUrl + "path1" + "/path2" + "." + "json?key1=value1";
        var request = new IssRequest();
        request.AddPath("path1");
        request.AddPath("path2");
        request.AddQuery("key1", "value1");
        request.TakeSnapshot();
        request.AddPath("path3");
        request.AddQuery("key2", "value2");

        // Act
        request.Dispose();

        // Assert
        Assert.Contains(".json", request.ToString());
        Assert.Equal(expected, request.ToString());
    }
}

public partial class IssRequestTest
{
    [Fact]
    public void AddPath_PathIsNullOrEmpty_ThrowsArgumentException()
    {
        // Arrange
        var pathManager = new IssRequest();
        var emptyPath = string.Empty;
        string? nullPath = null;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => pathManager.AddPath(emptyPath));
        Assert.Throws<ArgumentNullException>(() => pathManager.AddPath(nullPath));
    }

    [Theory]
    [InlineData("test", Format.Json)]
    [InlineData("test", Format.Xml)]
    public void AddPath_PathIsNotNullOrEmpty_AddsPathToPathsStorage(string path, Format format)
    {
        // Arrange
        var issRequest = new IssRequest(new IssRequestOptions { Format = format });
        var expected = baseUrl + path + '.' + format.ToString().ToLower();

        // Act
        issRequest.AddPath(path);

        // Assert
        Assert.True(issRequest.ContainsPath(path));
        Assert.True(Uri.IsWellFormedUriString(issRequest.ToString(), UriKind.Absolute));
        Assert.Equal(expected, issRequest.ToString());
    }
}

public partial class IssRequestTest
{
    [Fact]
    public void AddPaths_PathsIsNull_ThrowsArgumentNullException()
    {
        // Arrange
        var issRequest = new IssRequest();
        IEnumerable<string>? paths = null;

        // Act and Assert
        Assert.Throws<ArgumentNullException>(() => issRequest.AddPaths(paths));
    }

    [Theory]
    [InlineData("test1/test2", Format.Json)]
    [InlineData("test1/test2", Format.Xml)]
    public void AddPaths_PathsIsNotNull_AddsPathsToPathsStorage(string path, Format format)
    {
        // Arrange
        var issRequest = new IssRequest(new IssRequestOptions { Format = format });
        var expected = baseUrl + path + '.' + format.ToString().ToLower();
        var paths = path.Split("/");

        // Act
        issRequest.AddPaths(paths);

        // Assert
        Assert.All(paths, s => Assert.True(issRequest.ContainsPath(s)));
        Assert.True(Uri.IsWellFormedUriString(issRequest.ToString(), UriKind.Absolute));
        Assert.Equal(expected, issRequest.ToString());
    }
}

public partial class IssRequestTest
{
    [Theory]
    [InlineData("Test", "test", Format.Json)]
    [InlineData("Test", "test", Format.Xml)]
    public void AddQuery_KeyAndValueNotNullOrEmpty_AddsKeyAndValueToQueriesStorage(string key, string value,
        Format format)
    {
        // Arrange
        var issRequest = new IssRequest(new IssRequestOptions { Format = format });
        var expected = baseUrlWithoutSlash + '.' + format.ToString().ToLower() + '?' + key + "=" + value;

        // Act
        issRequest.AddQuery(key, value);

        // Assert
        Assert.True(issRequest.ContainsQuery(key));
        Assert.True(Uri.IsWellFormedUriString(issRequest.ToString(), UriKind.Absolute));
        Assert.Equal(issRequest.ToString(), expected);
    }

    [Theory]
    [InlineData(null, "test1")]
    [InlineData("Test2", null)]
    public void AddQuery_KeyOrValueIsNullOrEmpty_ThrowsArgumentNullException(string key, string value)
    {
        // Arrange
        var issRequest = new IssRequest();

        // Act and assert
        Assert.Throws<ArgumentNullException>(() => issRequest.AddQuery(key, value));
    }

    [Theory]
    [InlineData("", "test1")]
    [InlineData("Test2", "")]
    public void AddQuery_KeyOrValueIsEmpty_ThrowsArgumentException(string key, string value)
    {
        // Arrange
        var issRequest = new IssRequest();

        // Act and assert
        Assert.Throws<ArgumentException>(() => issRequest.AddQuery(key, value));
    }
}

public partial class IssRequestTest
{
    [Fact]
    public void AddQueries_QueriesIsNull_ThrowsArgumentNullException()
    {
        // Arrange
        var issRequest = new IssRequest();
        IEnumerable<KeyValuePair<string, string>>? queries = null;

        // Act and Assert
        Assert.Throws<ArgumentNullException>(() => issRequest.AddQueries(queries));
    }

    [Theory]
    [ClassData(typeof(Queries))]
    public void AddQueries_QueriesIsNotNull_AddsPathsToPathsStorage((List<KeyValuePair<string, string>> queries, Format format, string expected) parameters)
    {
        // Arrange
        var (queries, format, expected) = parameters;
        var issRequest = new IssRequest(new IssRequestOptions { Format = format });

        // Act
        issRequest.AddQueries(queries);

        // Assert
        Assert.All(queries, pair => Assert.True(issRequest.ContainsQuery(pair.Key)));
        Assert.True(Uri.IsWellFormedUriString(issRequest.ToString(), UriKind.Absolute));
        Assert.Equal(expected, issRequest.ToString());
    }
}

public partial class IssRequestTest
{
    [Fact]
    public void GetQueryValue_KeyExists_ReturnsValue()
    {
        // Arrange
        var issRequest = new IssRequest();
        const string key = "query1";
        issRequest.AddQuery(key, "value1");

        // Act
        var result = issRequest.GetQueryValue(key);

        // Assert
        Assert.Equal("value1", result);
    }

    [Fact]
    public void GetQueryValue_KeyDoesNotExist_ReturnsEmptyString()
    {
        // Arrange
        var issRequest = new IssRequest();
        const string key = "query1";

        // Act
        var result = issRequest.GetQueryValue(key);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void GetQueryValue_KeyIsNullOrEmpty_ThrowsArgumentException()
    {
        // Arrange
        var issRequest = new IssRequest();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => issRequest.GetQueryValue(string.Empty));
        Assert.Throws<ArgumentNullException>(() => issRequest.GetQueryValue(null));
    }
}

public partial class IssRequestTest
{
    [Fact]
    public void UpdateQuery_ExistingKey_ShouldUpdateValue()
    {
        // Arrange
        var request = new IssRequest();
        request.AddQuery("key1", "value1");

        // Act
        request.UpdateQuery("key1", "new_value");

        // Assert
        Assert.Equal("new_value", request.GetQueryValue("key1"));
    }

    [Fact]
    public void UpdateQuery_NonExistingKey_ShouldNotAddKey()
    {
        // Arrange
        var request = new IssRequest();

        // Act
        request.UpdateQuery("key1", "value1");

        // Assert
        Assert.False(request.ContainsQuery("key1"));
    }

    [Fact]
    public void UpdateQuery_EmptyKey_ShouldThrowArgumentException()
    {
        // Arrange
        var request = new IssRequest();

        // Act and Assert
        Assert.Throws<ArgumentException>(() => request.UpdateQuery(string.Empty, "value1"));
        Assert.Throws<ArgumentNullException>(() => request.UpdateQuery(null, "value1"));
    }
}

public partial class IssRequestTest
{
    [Fact]
    public void TakeSnapshot_WhenCalled_UpdatesPathsAndQueriesCount()
    {
        // Arrange
        var issRequest = new IssRequest();
        issRequest.AddPath("path1");
        issRequest.AddQuery("key1", "value1");

        // Act
        issRequest.TakeSnapshot();

        // Assert
        Assert.Equal(1, issRequest.PathsCountAfterSnapshot);
        Assert.Equal(1, issRequest.QueriesCountAfterSnapshot);
    }

    [Fact]
    public void TakeSnapshot_WhenNoPathsOrQueriesAdded_UpdatesCountToZero()
    {
        // Arrange
        var issRequest = new IssRequest();

        // Act
        issRequest.TakeSnapshot();

        // Assert
        Assert.Equal(0, issRequest.PathsCountAfterSnapshot);
        Assert.Equal(0, issRequest.QueriesCountAfterSnapshot);
    }

    [Fact]
    public void TakeSnapshot_AfterAddingAndUpdatingPathsAndQueries_ShouldNotAffectSnapshotCounts()
    {
        // Arrange
        var issRequest = new IssRequest();
        issRequest.AddPath("path1");
        issRequest.AddQuery("key1", "value1");
        issRequest.TakeSnapshot();

        // Act
        issRequest.AddPath("path2");
        issRequest.UpdateQuery("key1", "value2");

        // Assert
        Assert.Equal(1, issRequest.PathsCountAfterSnapshot);
        Assert.Equal(1, issRequest.QueriesCountAfterSnapshot);
    }

    [Fact]
    public void TakeSnapshot_AfterAddingNewPathOrQuery_ShouldUpdateSnapshotCounts()
    {
        // Arrange
        var issRequest = new IssRequest();
        issRequest.AddPath("path1");
        issRequest.AddQuery("key1", "value1");
        issRequest.TakeSnapshot();

        // Act
        issRequest.AddPath("path2");
        issRequest.AddQuery("key2", "value2");
        issRequest.TakeSnapshot();

        // Assert
        Assert.Equal(2, issRequest.PathsCountAfterSnapshot);
        Assert.Equal(2, issRequest.QueriesCountAfterSnapshot);
    }
}

public partial class IssRequestTest
{
    [Fact]
    public void Dispose_AddPathWithoutSnapshot_BaseUrl()
    {
        // Arrange
        const string expected = baseUrlWithoutSlash + "." + "json";
        var request = new IssRequest(new IssRequestOptions {Format = Format.Json});
        request.AddPath("path1");
        request.AddPath("path2");
        request.AddQuery("key1", "value1");

        // Act
        request.Dispose();

        // Assert
        Assert.Equal(expected, request.ToString());
    }

    [Fact]
    public void Dispose_AddPathWithSnapshot_UrlWithSnapshottedPaths()
    {
        // Arrange
        const string expected = baseUrl + "path1" + "/path2" + "." + "json?key1=value1";
        var request = new IssRequest(new IssRequestOptions {Format = Format.Json, CleanBehaviorForPaths = CleanBehavior.RevertSnapshotState, CleanBehaviorForQueries = CleanBehavior.RevertSnapshotState});
        request.AddPath("path1");
        request.AddPath("path2");
        request.AddQuery("key1", "value1");
        request.TakeSnapshot();
        request.AddPath("path3");
        request.AddQuery("key2", "value2");

        // Act
        request.Dispose();

        // Assert
        Assert.Equal(expected, request.ToString());
    }

    [Fact]
    public void Dispose_WhenCleanPathsAfterDisposeSettingIsClean_RemovesAllPaths()
    {
        // Arrange
        const string expected = baseUrlWithoutSlash + "." + "json";
        var request = new IssRequest(new IssRequestOptions { Format = Format.Json, CleanBehaviorForPaths = CleanBehavior.Clean, CleanBehaviorForQueries = CleanBehavior.Clean});
        request.AddPath("path1");
        request.AddPath("path2");
        request.AddQuery("key1", "value1");


        // Act
        request.Dispose();

        // Assert
        Assert.Equal(expected, request.ToString());
    }

    [Fact]
    public void Dispose_WhenCleanPathsAfterDisposeSettingIsNotClean_KeepsAllPaths()
    {
        // Arrange
        const string expected = baseUrl + "path1" + "/path2" + "." + "json?key1=value1";
        var request = new IssRequest(new IssRequestOptions { Format = Format.Json, CleanBehaviorForPaths = CleanBehavior.NotClean, CleanBehaviorForQueries = CleanBehavior.NotClean });
        request.AddPath("path1");
        request.AddPath("path2");
        request.AddQuery("key1", "value1");

        // Act
        request.Dispose();

        // Assert
        Assert.Equal(expected, request.ToString());
    }
}