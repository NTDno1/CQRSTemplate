using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Users;

namespace ERP.Domain.Entities.System.Users;

public sealed class User : EntityAuditBase<string>, ISoftDelete
{

    private User()
    {

    }


    private User(string id, string hoten, string passwordHashed, string passwordConfirmationHashed, string? avatar, string noiLamViec)
    {
        Id = id;
        HoTen = hoten;
        PasswordHashed = passwordHashed;
        PasswordConfirmationHashed = passwordConfirmationHashed;
        Avatar = avatar;
        NoiLamViec = noiLamViec;
        Avatar = avatar;
    }

    public string HoTen { get; private set; }

    public string PasswordHashed { get; private set; }

    public string PasswordConfirmationHashed { get; private set; }

    public string? Avatar { get; private set; }

    public Ulid IdPhongBan { get; private set; }

    public string NoiLamViec { get; private set; }

    public bool IsLocked { get; private set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    public ICollection<Role> Roles { get; set; } = new List<Role>();

    public PhongBan PhongBan { get; set; }

    public static User Create(string id, string hoten, string passwordHashed, string passwordConfirmationHashed, string? avatar = null, string noiLamViec = "HOPLONG")
    {
        var user = new User(id, hoten, passwordHashed, passwordConfirmationHashed, avatar, noiLamViec);

        return user;
    }




}
