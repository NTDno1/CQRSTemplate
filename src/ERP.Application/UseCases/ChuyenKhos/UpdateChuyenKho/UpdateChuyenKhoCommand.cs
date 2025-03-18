using ERP.Share.Abstractions.Shared;
using ERP.Share.DTO;

namespace ERP.Application.UseCases.ChuyenKhos.UpdateWhChuyenKho;
public sealed record UpdateChuyenKhoCommand(
 Ulid idChuyenKho,

 string? dienGiai,

 string? TrucThuoc,

 string? HinhThucChuyen,

 string? soBill,

 Ulid? idKhoXuatHang,

 Ulid? idKhoNhanHang,

 string? tTrangThai,

 string? ngayXacNhanXuat,

 string? nguoiXacNhanXuat,

 string? nguoiNhanHang,

 string? thoiGianNhanHang,

 bool? canXuatHoaDon,

 string? soHoaDon,
 List<UpdateChuyenKhoChiTietDTO> chuyenKhoChiTiet) : ICommand;
