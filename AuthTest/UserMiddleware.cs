namespace AuthTest;

public class UserMiddleware
{  
    private readonly RequestDelegate _next;
    public UserMiddleware(RequestDelegate next)
    {
        _next = next;
    }
  
    public async Task Invoke(HttpContext httpContext)
    {
        var identifierClaim = httpContext.User.Claims; // This should not be an empty list and user should be populated.
        
        await _next.Invoke(httpContext);
    }
}