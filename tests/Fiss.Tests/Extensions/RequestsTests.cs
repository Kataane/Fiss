namespace Fiss.Tests;

public class RequestsTests
{
    [Fact]
    public void MethodNameToPath_AddsPathFromCallerMemberName()
    {
        // Arrange
        const string path = nameof(MethodNameToPath_AddsPathFromCallerMemberName);
        var request = new Mock<IIssRequest>();
        var paths = new List<string>();
        request.Setup(r => r.AddPath(It.IsAny<string>())).Callback((string s) => paths.Add(s));
        
        // Act
        request.Object.MethodNameToPath();

        // Assert
        request.Verify(r => r.AddPath(It.IsAny<string>()), Times.Exactly(1));
        
        Assert.Single(paths);
        Assert.Contains(paths[0], path.ToLowerInvariant());
    }
    
    [Fact]
    public void MethodNameToPath_AddsPathFromCallerMemberNameAndAdditionalPath()
    {
        // Arrange
        const string path = nameof(MethodNameToPath_AddsPathFromCallerMemberNameAndAdditionalPath);
        const string additionalPath = "Test";
        
        var request = new Mock<IIssRequest>();
        var paths = new List<string>();

        request.Setup(r => r.AddPath(It.IsAny<string>())).Callback((string s) => paths.Add(s));
        
        // Act
        request.Object.MethodNameToPath(additionalPath);

        // Assert
        request.Verify(r => r.AddPath(It.IsAny<string>()), Times.Exactly(2));
        request.Verify(r => r.AddPath(path.ToLowerInvariant()), Times.Exactly(1));
        request.Verify(r => r.AddPath(additionalPath.ToLowerInvariant()), Times.Exactly(1));
        
        Assert.Equal(2, paths.Count);
        Assert.Contains(paths[0], path.ToLowerInvariant());
        Assert.Contains(paths[1], additionalPath.ToLowerInvariant());
    }
}