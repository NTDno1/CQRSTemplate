using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CM.CreateDeNghiThanhToanCM;
public sealed record CreateDNThanhToanCMCommand(
    string noiDungNgheNghiThanhToan,
    decimal tongTien,
    Ulid idKhachHang,
    string trucThuoc,
    string nguoiDuyet,
    string ngayDuyet,
    string trangThai,
    string? lyDoHuy,
    bool daThanhToan,
    string nguoiThanhToan,
    string ngayThanhToan,
    string hinhThucThanhToan,
    string thanhToanTheoTaiKhoan,
    string taiKhoanNganHangNhan,
    string soTaiKhoan,
    string nganHang,
    string chiNhanhNganHang,
    string nguoiThuHuong,
    string ngayThanhToanDuKien,
    decimal soTienGiamTru
    ) : ICommand;
