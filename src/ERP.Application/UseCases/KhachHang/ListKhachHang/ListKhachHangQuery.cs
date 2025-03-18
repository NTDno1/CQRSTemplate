using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.KhachHang.ListKhachHang;
public sealed record ListKhachHangQuery(
    string? tuNgay,
    string? denNgay,
    string? maKhachHang,
    string? soDienThoai,
    string? sr,
    string? sa,
    string? sr2,
    int? soTrang,
    int? kichThuocTrang) : IQuery;
