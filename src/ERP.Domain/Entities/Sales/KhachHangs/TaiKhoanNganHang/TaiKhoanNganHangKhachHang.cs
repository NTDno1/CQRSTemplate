using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.KhachHang.TaiKhoanNganHang;

public sealed class TaiKhoanNganHangKhachHang : AggregateRoot
{

    private TaiKhoanNganHangKhachHang()
    {
    }

    public TaiKhoanNganHangKhachHang(
                                     string soTaiKhoan,
                                     Ulid idKhachHang,
                                     LoaiTaiKhoan loaiTaiKhoan,
                                     string tenTaiKhoan,
                                     string nganHang,
                                     string chiNhanh,
                                     string tinhThanhPho,
                                     HinhThucThanhToan hinhThucThanhToan)
    {
        Id = Ulid.NewUlid();
        SoTaiKhoan = soTaiKhoan;
        IdKhachHang = idKhachHang;
        LoaiTaiKhoan = loaiTaiKhoan;
        TenTaiKhoan = tenTaiKhoan;
        NganHang = nganHang;
        ChiNhanh = chiNhanh;
        TinhThanhPho = tinhThanhPho;
        HinhThucThanhToan = hinhThucThanhToan;
    }

    public string SoTaiKhoan { get; private set; }

    public Ulid IdKhachHang { get; private set; }

    public LoaiTaiKhoan LoaiTaiKhoan { get; private set; }

    public string TenTaiKhoan { get; private set; }

    public string NganHang { get; private set; }

    public string ChiNhanh { get; private set; }

    public string TinhThanhPho { get; private set; }

    public HinhThucThanhToan HinhThucThanhToan { get; private set; }

    public KhachHang KhachHang { get; private set; }

    public static TaiKhoanNganHangKhachHang Create(
        string soTaiKhoan,
        Ulid idKhachHang,
        LoaiTaiKhoan loaiTaiKhoan,
        string? tenTaiKhoan,
        string? nganHang,
        string? chiNhanh,
        string? tinhThanhPho,
        HinhThucThanhToan hinhThucThanhToan)
    {
        return new TaiKhoanNganHangKhachHang(
            soTaiKhoan,
            idKhachHang,
            loaiTaiKhoan,
            tenTaiKhoan ?? string.Empty,
            nganHang ?? string.Empty,
            chiNhanh ?? string.Empty,
            tinhThanhPho ?? string.Empty,
            hinhThucThanhToan);
    }

    public void Update(string? soTaiKhoan,
                       LoaiTaiKhoan? loaiTaiKhoan,
                       string? tenTaiKhoan,
                       string? nganHang,
                       string? chiNhanh,
                       string? tinhThanhPho,
                       HinhThucThanhToan? hinhThucThanhToan)
    {
        SoTaiKhoan = !string.IsNullOrEmpty(soTaiKhoan) ? soTaiKhoan : SoTaiKhoan;
        LoaiTaiKhoan = loaiTaiKhoan ?? LoaiTaiKhoan;
        TenTaiKhoan = !string.IsNullOrEmpty(tenTaiKhoan) ? tenTaiKhoan : TenTaiKhoan;
        NganHang = !string.IsNullOrEmpty(nganHang) ? nganHang : NganHang;
        ChiNhanh = !string.IsNullOrEmpty(chiNhanh) ? chiNhanh : ChiNhanh;
        TinhThanhPho = !string.IsNullOrEmpty(tinhThanhPho) ? tinhThanhPho : TinhThanhPho;
        HinhThucThanhToan = hinhThucThanhToan ?? HinhThucThanhToan;
    }
}
