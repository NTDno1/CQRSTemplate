using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Shared;

namespace ERP.Domain.Entities.HR.CongTacPhi;

public sealed class CongTacPhi : AggregateRoot, ISoftDelete
{

    //private readonly List<CongTacPhiPhuongTien.CongTacPhiPhuongTien> _congTacPhiPhuongTiens;
    private CongTacPhi()
    {
        //_congTacPhiPhuongTiens = [];
    }

    public string MaSoDeNghi { get; private set; }
    public int Thu { get; private set; }
    public DateTime Ngay { get; private set; }
    public KhoangThoiGian KhoangThoiGian { get; private set; }
    public string DiaDiem { get; private set; }
    public LoaiCongViec LoaiCongViec { get; private set; }
    public string NoiDungCongViec { get; private set; }
    public float SoGioLamThem { get; private set; }
    public decimal TienAnLamThem { get; private set; }
    public decimal PhiPhuongTien { get; private set; }
    public decimal PhuCapLuuTru { get; private set; }
    public decimal TienThuPhong { get; private set; }
    public decimal? ChiPhiKhac { get; private set; }
    public string IdUserDeNghi { get; private set; }
    public DateTime NgayDeNghi { get; private set; }
    public DuyetDon TruongPhongDuyet { get; private set; }
    public DuyetDon KeToanDuyet { get; private set; }
    public TrangThaiThanhToan TrangThaiThanhToan { get; private set; }
    public decimal TongThanhToan { get; private set; }
    public string IdUserThanhToan { get; private set; }
    public DateTime? NgayThanhToan { get; private set; }
    public DateTime? DaHuy { get; private set; }
    public string? IdUserHuy { get; private set; }
    public string? LyDoHuy { get; private set; }
    public TrucThuoc TrucThuoc { get; private set; }
    public string? GhiChu { get; private set; }
    public DateOnly? ThoiGianDiLai { get; private set; }
    public string? KeToanGhiChu { get; private set; }
    public DateOnly? ThoiGianTinhPhuCap { get; private set; }
    public decimal TongThanhToanThucTe { get; private set; }
    public bool CongTacBenNgoai { get; private set; }
    public bool CheckTruocKhiDuyetB1 { get; private set; }
    public bool TamTruQuaDem { get; private set; }
    public bool DiDuongXa { get; private set; }
    public string DiemDi { get; private set; }
    public string DiemDen { get; private set; }
    public decimal TienAnSang { get; private set; }
    public decimal TienAnTrua { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    //public IReadOnlyCollection<CongTacPhiPhuongTien.CongTacPhiPhuongTien> CongTacPhiPhuongTiens => _congTacPhiPhuongTiens.AsReadOnly();

}
