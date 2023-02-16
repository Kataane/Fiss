namespace Fiss.Response;

public interface IIssResponse : IDisposable
{
    public Task<Stream> Read();
}