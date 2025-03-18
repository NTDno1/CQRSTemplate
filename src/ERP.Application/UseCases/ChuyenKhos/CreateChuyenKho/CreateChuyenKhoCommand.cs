using ERP.Share.Abstractions.Shared;
using ERP.Share.DTO;

namespace ERP.Application.UseCases.ChuyenKhos.CreateWhChuyenKho;
public sealed record CreateChuyenKhoCommand(
string DienGiai,
string TrucThuoc,
string? SoBill,
string? HinhThucChuyen,
Ulid IdKhoXuatHang,
Ulid IdKhoNhanHang,
string? NgayXacNhanXuat,
string? NguoiXacNhanXuat,
string? NguoiNhanHang,
string? ThoiGianNhanHang,
string? SoHoaDon,
List<AddChuyenKhoChiTietDTO> AddChuyenKhoChiTiets
    ) : ICommand;
