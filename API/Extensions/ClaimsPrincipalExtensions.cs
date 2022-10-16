using System.Security.Claims;

namespace API.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string RetriveEmailFromPrincipal(this ClaimsPrincipal user)
    {
        return user.FindFirstValue(ClaimTypes.Email);
        //user?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
    }
}