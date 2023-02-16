namespace Fiss.Response;

public class IssResponse : IIssResponse
{
    private readonly HttpResponseMessage response;

    public IssResponse(HttpResponseMessage response)
    {
        this.response = response;
    }

    public async Task<Stream> Read()
    {
        return await response.Content.ReadAsStreamAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            response.Dispose();
        }
    }
}