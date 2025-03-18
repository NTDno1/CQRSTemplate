using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Sales.BaoGias.BaoGiaChiTiet;
using ERP.Domain.Entities.Shared;

namespace ERP.Domain.Entities.Sales.CongNoSR;

public sealed class CongNoSR : AggregateRoot, ISoftDelete
{
    private readonly List<CongNoSRComment> _congNoSRComments;

    private CongNoSR()
    {
        _congNoSRComments = [];
    }

    public Ulid IdKhachHang { get; private set; }
    public string LoaiNV { get; private set; }
    public decimal TongNo { get; private set; }
    public decimal NoQuaHan { get; private set; }
    public decimal NoDenHan { get; private set; }
    public KhoangThoiGian KhoangThoiGian { get; private set; }
    public DateOnly NgayDenHenThanhToan { get; private set; }
    public decimal SoTienHenThanhToan { get; private set; }
    public decimal SoTienDuKienVe { get; private set; }
    public string KetQuaThuHoi { get; private set; }
    public decimal NoNoiBoQuaHan { get; private set; }
    public decimal TongCo { get; private set; }
    public decimal CongNoXau { get; private set; }
    public decimal No_1_30_Ngay { get; private set; }
    public decimal No_30_45_Ngay { get; private set; }
    public decimal NoTren60Ngay { get; private set; }
    public bool KhachHenChuaThanhToan { get; private set; }
    public decimal No_1_7_Ngay { get; private set; }
    public decimal No_7_15_Ngay { get; private set; }
    public decimal No_15_30_Ngay { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public IReadOnlyCollection<CongNoSRComment> CongNoSRComments => _congNoSRComments.AsReadOnly();

    public void Update(
    Ulid? idKhachHang,
    decimal? soTienHenThanhToan,
    string? ketQuaThuHoi
    )
    {
        IdKhachHang = idKhachHang ?? IdKhachHang;
        SoTienHenThanhToan = soTienHenThanhToan ?? SoTienHenThanhToan;
        KetQuaThuHoi = !string.IsNullOrEmpty(ketQuaThuHoi) ? ketQuaThuHoi : KetQuaThuHoi;
    }

    public static CongNoSR Create(
    Ulid idKhachHang,
    string loaiNV,
    decimal tongNo,
    decimal noQuaHan,
    decimal noDenHan,
    KhoangThoiGian khoangThoiGian,
    DateOnly ngayDenHenThanhToan,
    decimal soTienHenThanhToan,
    decimal soTienDuKienVe,
    string ketQuaThuHoi,
    decimal noNoiBoQuaHan,
    decimal tongCo,
    decimal congNoXau,
    decimal no_1_30_Ngay,
    decimal no_30_45_Ngay,
    decimal noTren60Ngay,
    bool khachHenChuaThanhToan,
    decimal no_1_7_Ngay,
    decimal no_7_15_Ngay,
    decimal no_15_30_Ngay)
    {
        return new CongNoSR
        {
            Id = Ulid.NewUlid(),
            IdKhachHang = idKhachHang,
            LoaiNV = loaiNV,
            TongNo = tongNo,
            NoQuaHan = noQuaHan,
            NoDenHan = noDenHan,
            KhoangThoiGian = khoangThoiGian,
            NgayDenHenThanhToan = ngayDenHenThanhToan,
            SoTienHenThanhToan = soTienHenThanhToan,
            SoTienDuKienVe = soTienDuKienVe,
            KetQuaThuHoi = ketQuaThuHoi,
            NoNoiBoQuaHan = noNoiBoQuaHan,
            TongCo = tongCo,
            CongNoXau = congNoXau,
            No_1_30_Ngay = no_1_30_Ngay,
            No_30_45_Ngay = no_30_45_Ngay,
            NoTren60Ngay = noTren60Ngay,
            KhachHenChuaThanhToan = khachHenChuaThanhToan,
            No_1_7_Ngay = no_1_7_Ngay,
            No_7_15_Ngay = no_7_15_Ngay,
            No_15_30_Ngay = no_15_30_Ngay
        };
    }
}
