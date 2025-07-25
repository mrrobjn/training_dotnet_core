using System.Diagnostics.CodeAnalysis;

namespace MySession.MySession;

public class MySession : ISession
{
    public Task LoadAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task CommitAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public bool TryGetValue(string key, [NotNullWhen(true)] out byte[]? value)
    {
        throw new NotImplementedException();
    }

    public void Set(string key, byte[] value)
    {
        throw new NotImplementedException();
    }

    public void Remove(string key)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool IsAvailable { get; }
    public string Id { get; }
    public IEnumerable<string> Keys { get; }
}