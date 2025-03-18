using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.LoaiKhachHang.ListLoaiKhachHang;
public sealed record ListKhachHangLoaiQuery(
    string? tuNgay,
    string? denNgay,
    string? tenLoaiKhach,
    int? soTrang,
    int? kichThuocTrang) : IQuery;
