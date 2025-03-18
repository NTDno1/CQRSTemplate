using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.System.Users;

namespace ERP.Domain.Entities.Users;

public sealed class PhongBan : AggregateRoot, ISoftDelete
{

    private PhongBan()
    {

    }

    private PhongBan(string maphongban, string tenPhongBan, string? trucThuocPhongBan, string? truongPhong, string? phoPhong)
    {
        Id = Ulid.NewUlid();
        MaPhongBan = maphongban;
        TenPhongBan = tenPhongBan;
        TrucThuocPhongBan = trucThuocPhongBan;
        TruongPhong = truongPhong;
        PhoPhong = phoPhong;
    }
    public string MaPhongBan { get; private set; }

    public string TenPhongBan { get; private set; }

    public string? TrucThuocPhongBan { get; private set; }

    public string? TruongPhong { get; private set; }

    public string? PhoPhong { get; private set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    private readonly List<User> _users = new List<User>();

    public ICollection<User> Users => _users.AsReadOnly();

    public static PhongBan Create(string maPhongBan, string tenPhongBan, string? trucThuocPhongBan, string? truongPhong, string? phongPhong)
    {
        PhongBan phongBan = new PhongBan(maPhongBan, tenPhongBan, trucThuocPhongBan, truongPhong, phongPhong);
        return phongBan;
    }
}
