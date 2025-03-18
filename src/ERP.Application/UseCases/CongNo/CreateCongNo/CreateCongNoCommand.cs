using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.CreateCongNo;

public sealed record CreateCongNoCommand(
    Ulid IdKhachHang,
    string LoaiNV,
    decimal TongNo,
    decimal NoQuaHan,
    decimal NoDenHan,
    string tungay,
    string denngay,
    string NgayDenHenThanhToan,
    decimal SoTienHenThanhToan,
    decimal SoTienDuKienVe,
    string KetQuaThuHoi,
    decimal NoNoiBoQuaHan,
    decimal TongCo,
    decimal CongNoXau,
    decimal No_1_30_Ngay,
    decimal No_30_45_Ngay,
    decimal NoTren60Ngay,
    bool KhachHenChuaThanhToan,
    decimal No_1_7_Ngay,
    decimal No_7_15_Ngay,
    decimal No_15_30_Ngay) : ICommand;

