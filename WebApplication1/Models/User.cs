namespace WebApplication1.Models;

public class User : IUserRepository
{
    private readonly List<string> users = [];
    
    public void Add(string user)
    {
        users.Add(user);
    }

    public string Id { get; set;}
    
    public IEnumerable<string> Users { get => users; set => users.Clear(); }
}