using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiThanhToanCM.UpdateDeNghiThanhToanCM;
public sealed record UpdateDNThanhToanCMCommand
(
    Ulid Id,
    string hinhThucThanhToan,
    string noiDungNgheNghiThanhToan,
    string soTaiKhoan,
    string nganHang,
    string chiNhanhNganHang,
    string nguoiThuHuong
) : ICommand;
