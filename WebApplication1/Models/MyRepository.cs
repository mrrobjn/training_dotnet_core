using Microsoft.AspNetCore.Components;

namespace WebApplication1.Models;

public class MyRepository : IRepository
{
    private readonly ILogger<MyRepository> logger;

    public MyRepository(ILogger<MyRepository> logger)
    {
        this.logger = logger;
        logger.LogInformation("Created MyRepository");
    }
    
    public string getById(string id)
    {
        return $"ID: {id}";
    }
}