using System.Security.Claims;
using OCALIPTUS.Application.Common.Interfaces;

namespace OCALIPTUS.AdminUI.Services;

public class CurrentUserService : ICurrentUserService
{
    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        string UserIdStr = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        string fullName = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.GivenName);
        UserId = Convert.ToInt64(UserIdStr);
        IsAuthenticated = UserId != null;
        FullName = fullName;
    }

    public long UserId { get; }
    public string FullName { get; }
    public bool IsAuthenticated { get; }
}