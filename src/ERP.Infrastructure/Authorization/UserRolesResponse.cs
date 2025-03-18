using ERP.Domain.Entities.System.Users;

namespace ERP.Infrastructure.Authorization;
internal sealed class UserRolesResponse
{
    public string UserId { get; init; }

    public List<Role> Roles { get; init; } = [];
}
