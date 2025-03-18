using System.Security.Claims;
namespace ERP.Infrastructure.Authentication;
internal static class ClaimsPrincipalExtensions
{
    public static string GetUserId(this ClaimsPrincipal? principal)
    {
        string? userId = principal?.FindFirstValue(ClaimTypes.Sid);

        return userId ??
            throw new ApplicationException("User id is unavailable");
    }

    public static string GetUserName(this ClaimsPrincipal? principal)
    {
        return principal?.FindFirstValue(ClaimTypes.Name) ??
               throw new ApplicationException("User identity is unavailable");
    }
}
