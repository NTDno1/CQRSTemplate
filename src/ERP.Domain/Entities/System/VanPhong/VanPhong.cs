using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.System.Users;

namespace ERP.Domain.Entities.System.VanPhong;

public sealed class VanPhong : AggregateRoot, ISoftDelete
{

    private VanPhong()
    {

    }

    private VanPhong(string maVanPhong, string tenVanPhong)
    {
        Id = Ulid.NewUlid();
        MaVanPhong = maVanPhong;
        TenVanPhong = tenVanPhong;
        IsLocked = false;
    }

    public string MaVanPhong { get; private set; }

    public string TenVanPhong { get; private set; }

    public bool IsLocked { get; private set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    public ICollection<User> Users { get; } = new List<User>();

    public static VanPhong Create(string maVanPhong, string tenVanPhong)
    {
        var vanPhong = new VanPhong(maVanPhong, tenVanPhong);
        return vanPhong;
    }
}
