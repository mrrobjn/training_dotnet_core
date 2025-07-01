namespace MySession.MySession;

public static class MySessionExtension
{
    public const string SessionId = "MySessionId";
    
    public static ISession GetSession(this HttpContext context)
    {
        return context.Session;
    }
}