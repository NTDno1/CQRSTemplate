using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.KhachHangLienHe.ListKhachHangLienHe;
public sealed record ListKhachHangLienHeQuery(
    string? tuNgay,
    string? denNgay,
    string? tenLienHe,
    int? soTrang,
    int? kichThuocTrang) : IQuery;
