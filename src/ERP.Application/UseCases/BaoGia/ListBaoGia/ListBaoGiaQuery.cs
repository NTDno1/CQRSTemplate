using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.BaoGia.ListBaoGia;
public sealed record ListBaoGiaQuery(
    string? tuNgay,
    string? denNgay,
    string? soBaoGia,
    string? tenKhachHang,
    string? tenSaleBaoGia,
    string? congTy,
    string? tenMarkPhuTrach,
    int? soTrang,
    int? kichThuocTrang
    ) : IQuery;
