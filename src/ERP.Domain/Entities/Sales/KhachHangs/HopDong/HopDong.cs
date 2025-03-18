using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.Sales.KhachHang.HopDong;

public sealed class HopDong : AggregateRoot, ISoftDelete
{

    private HopDong()
    {

    }

    public Ulid IdKhachHang { get; private set; }
    public int Nam { get; private set; }
    public LoaiHopDong LoaiHopDong { get; private set; }
    public string? GhiChu { get; private set; }
    public DateOnly? NgayHopDong { get; private set; }
    public string? SoHopDong { get; private set; }
    public string? SoQuyen { get; private set; }
    public int SoThuTu { get; private set; }
    public string? DieuKhoanThanhToan { get; private set; }
    public decimal? HanMucTinDung { get; private set; }
    public DateOnly? NgayHetHan { get; private set; }
    public TrangThai TrangThai { get; private set; }
    public bool GiaHan1Nam { get; private set; }
    public bool? GiaHanHangNam { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }
}
