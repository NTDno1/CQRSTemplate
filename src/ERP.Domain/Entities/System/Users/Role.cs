using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.System.Users;

public sealed class Role : AggregateRoot
{
    public static readonly Role User = new Role("User");
    public Role(string name)
    {
        Id = Ulid.NewUlid();
        Name = name;
    }

    public string Name { get; init; }

    public ICollection<User> Users { get; init; } = new List<User>();

    public ICollection<Permission> Permissions { get; init; } = new List<Permission>();
}
