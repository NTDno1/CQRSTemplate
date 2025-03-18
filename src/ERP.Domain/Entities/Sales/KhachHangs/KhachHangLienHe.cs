using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.KhachHang;


public sealed class KhachHangLienHe : AggregateRoot
{

    private KhachHangLienHe()
    {

    }

    public KhachHangLienHe(string tenLienHe, Ulid idKhachHang, string vaiTro, string soDienThoai, string email, TinhTrangKhachHangLienHe tinhTrang, string ghiChu)
    {
        Id = Ulid.NewUlid();
        IdKhachHang = idKhachHang;
        TenLienHe = tenLienHe;
        VaiTro = vaiTro;
        SoDienThoai = soDienThoai;
        Email = email;
        TinhTrang = tinhTrang;
        GhiChu = ghiChu;
    }

    public Ulid IdKhachHang { get; private set; }
    public string TenLienHe { get; private set; }
    public string VaiTro { get; private set; }
    public string SoDienThoai { get; private set; }
    public string Email { get; private set; }
    public TinhTrangKhachHangLienHe TinhTrang { get; private set; }
    public string GhiChu { get; private set; }
    public KhachHang KhachHang { get; private set; }

    public static KhachHangLienHe Create(
    string tenLienHe,
    Ulid idKhachHang,
    string vaiTro,
    string soDienThoai,
    string email,
    TinhTrangKhachHangLienHe tinhTrang,
    string ghiChu)
    {
        return new KhachHangLienHe(
            tenLienHe,
            idKhachHang,
            vaiTro,
            soDienThoai,
            email,
            tinhTrang,
            ghiChu
        );
    }
    public void Update(
    string? tenLienHe,
    string? vaiTro,
    string? soDienThoai,
    string? email,
    TinhTrangKhachHangLienHe? tinhTrang,
    string? ghiChu)
    {
        TenLienHe = !string.IsNullOrEmpty(tenLienHe) ? tenLienHe : TenLienHe;
        VaiTro = !string.IsNullOrEmpty(vaiTro) ? vaiTro : VaiTro;
        SoDienThoai = !string.IsNullOrEmpty(soDienThoai) ? soDienThoai : SoDienThoai;
        Email = !string.IsNullOrEmpty(email) ? email : Email;
        TinhTrang = tinhTrang ?? TinhTrang;
        GhiChu = !string.IsNullOrEmpty(ghiChu) ? ghiChu : GhiChu;
    }
}
