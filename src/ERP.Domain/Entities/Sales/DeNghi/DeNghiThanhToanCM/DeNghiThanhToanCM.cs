using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Domain.Entities.Sales.DeNghiThanhToan.DeNghiThanhToanCM;
using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Domain.Entities.Shared;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;

public sealed class DeNghiThanhToanCM : AggregateRoot, ISoftDelete
{
    private readonly List<DeNghiThanhToanCMChiTiet> _deNghiThanhToanCMChiTiets;
    private DeNghiThanhToanCM()
    {
        _deNghiThanhToanCMChiTiets = [];
    }
    public string MaDeNghi { get; private set; }
    public string NoiDungNgheNghiThanhToan { get; private set; }
    public decimal TongTien { get; private set; }
    public Ulid IdKhachHang { get; private set; }
    public TrucThuoc TrucThuoc { get; private set; }
    public string NguoiDuyet { get; private set; }
    public DateTime NgayDuyet { get; private set; }
    public TrangThaiDuyetDNTT TrangThai { get; private set; }
    public string? LyDoHuy { get; private set; }
    public bool DaThanhToan { get; private set; }
    public string NguoiThanhToan { get; private set; }
    public DateOnly NgayThanhToan { get; private set; }
    public HinhThucThanhToan HinhThucThanhToan { get; private set; }
    public ThanhToanTheoTaiKhoan ThanhToanTheoTaiKhoan { get; private set; }
    public TaiKhoanNganHang TaiKhoanNganHangNhan { get; private set; }
    public DateOnly NgayThanhToanDuKien { get; private set; }
    public decimal SoTienGiamTru { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public DeNghiThanhToanCM(string maDeNghi,
                             string noiDungNgheNghiThanhToan,
                             decimal tongTien,
                             Ulid idKhachHang,
                             TrucThuoc trucThuoc,
                             string nguoiDuyet,
                             DateTime ngayDuyet,
                             TrangThaiDuyetDNTT trangThai,
                             string? lyDoHuy,
                             bool daThanhToan,
                             string nguoiThanhToan,
                             DateOnly ngayThanhToan,
                             HinhThucThanhToan hinhThucThanhToan,
                             ThanhToanTheoTaiKhoan thanhToanTheoTaiKhoan,
                             TaiKhoanNganHang taiKhoanNganHangNhan,
                             DateOnly ngayThanhToanDuKien,
                             decimal soTienGiamTru)
    {
        MaDeNghi = maDeNghi;
        NoiDungNgheNghiThanhToan = noiDungNgheNghiThanhToan;
        TongTien = tongTien;
        IdKhachHang = idKhachHang;
        TrucThuoc = trucThuoc;
        NguoiDuyet = nguoiDuyet;
        NgayDuyet = ngayDuyet;
        TrangThai = trangThai;
        LyDoHuy = lyDoHuy;
        DaThanhToan = daThanhToan;
        NguoiThanhToan = nguoiThanhToan;
        NgayThanhToan = ngayThanhToan;
        HinhThucThanhToan = hinhThucThanhToan;
        ThanhToanTheoTaiKhoan = thanhToanTheoTaiKhoan;
        TaiKhoanNganHangNhan = taiKhoanNganHangNhan;
        NgayThanhToanDuKien = ngayThanhToanDuKien;
        SoTienGiamTru = soTienGiamTru;
    }

    public static DeNghiThanhToanCM Create(
    string maDeNghi,
    string noiDungNgheNghiThanhToan,
    decimal tongTien,
    Ulid idKhachHang,
    string trucThuoc,
    string nguoiDuyet,
    DateTime ngayDuyet,
    string trangThai,
    string? lyDoHuy,
    bool daThanhToan,
    string nguoiThanhToan,
    DateOnly ngayThanhToan,
    string hinhThucThanhToan,
    string thanhToanTheoTaiKhoan,
    string soTaiKhoan,
    string nganHang,
    string chiNhanhNganHang,
    string nguoiThuHuong,
    DateOnly ngayThanhToanDuKien,
    decimal soTienGiamTru)
    {
        var trucThuocEnum = TrucThuoc.FromValue(trucThuoc);

        var trangthaiEnum = TrangThaiDuyetDNTT.FromValue(trangThai);
        var hinhThucThanhToanEnum = HinhThucThanhToan.FromValue(hinhThucThanhToan);
        var thanhToanTheoTaiKhoanEnum = ThanhToanTheoTaiKhoan.FromValue(thanhToanTheoTaiKhoan);

        var taiKhoanNganHangNhan = TaiKhoanNganHang.Create(soTaiKhoan, nganHang, chiNhanhNganHang, nguoiThuHuong);

        return new DeNghiThanhToanCM
        {
            Id = Ulid.NewUlid(),
            MaDeNghi = maDeNghi,
            NoiDungNgheNghiThanhToan = noiDungNgheNghiThanhToan,
            TongTien = tongTien,
            IdKhachHang = idKhachHang,
            TrucThuoc = trucThuocEnum,
            NguoiDuyet = nguoiDuyet,
            NgayDuyet = ngayDuyet,
            TrangThai = trangthaiEnum,
            LyDoHuy = lyDoHuy,
            DaThanhToan = daThanhToan,
            NguoiThanhToan = nguoiThanhToan,
            NgayThanhToan = ngayThanhToan,
            HinhThucThanhToan = hinhThucThanhToanEnum,
            ThanhToanTheoTaiKhoan = thanhToanTheoTaiKhoanEnum,
            TaiKhoanNganHangNhan = taiKhoanNganHangNhan,
            NgayThanhToanDuKien = ngayThanhToanDuKien,
            SoTienGiamTru = soTienGiamTru
        };
    }

    public void Update(
        string hinhThucThanhToan,
        string noiDungNgheNghiThanhToan,
        string soTaiKhoan,
        string nganHang,
        string chiNhanhNganHang,
        string nguoiThuHuong)
    {
        string soTaiKhoans = soTaiKhoan ?? TaiKhoanNganHangNhan.SoTaiKhoan;
        string nganHangs = nganHang ?? TaiKhoanNganHangNhan.NganHang;
        string chiNhanhNganHangs = chiNhanhNganHang ?? TaiKhoanNganHangNhan.ChiNhanhNganHang;
        string nguoiThuHuongs = nguoiThuHuong ?? TaiKhoanNganHangNhan.NguoiThuHuong;
        HinhThucThanhToan = hinhThucThanhToan != null ? HinhThucThanhToan.FromValue(hinhThucThanhToan) : HinhThucThanhToan;
        NoiDungNgheNghiThanhToan = noiDungNgheNghiThanhToan ?? NoiDungNgheNghiThanhToan;
        TaiKhoanNganHangNhan = TaiKhoanNganHang.Create(soTaiKhoans, nganHangs, chiNhanhNganHangs, nguoiThuHuongs);
    }

    public IReadOnlyCollection<DeNghiThanhToanCMChiTiet> DeNghiThanhToanCMChiTiets => _deNghiThanhToanCMChiTiets.AsReadOnly();
}
