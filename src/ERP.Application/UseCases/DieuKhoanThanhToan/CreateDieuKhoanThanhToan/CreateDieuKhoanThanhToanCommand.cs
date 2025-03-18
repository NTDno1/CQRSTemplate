using ERP.Share.Abstractions.Shared;
using ERP.Share.DTO;

namespace ERP.Application.UseCases.DieuKhoanThanhToan.CreateDieuKhoanThanhToan;
public sealed record CreateDieuKhoanThanhToanCommand(
    string thoiHanThanhToan,
    string loaiDieuKhoanThanhToan,
    DieuKhoanThanhToanDTO dieuKhoanThanhToanNo1,
    DieuKhoanThanhToanDTO dieuKhoanThanhToanNo2,
    DieuKhoanThanhToanDTO dieuKhoanThanhToanNo3,
    decimal phanTramThanhToan,
    bool isActiveAuto,
    bool isActiveGiga) : ICommand;
