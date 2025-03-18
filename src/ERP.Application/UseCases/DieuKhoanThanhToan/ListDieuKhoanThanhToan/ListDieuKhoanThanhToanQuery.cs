using ERP.Share.Abstractions.Shared;

public sealed record ListDieuKhoanThanhToanQuery(
    string? tuNgay,
    string? denNgay,
    string? thoiHanThanhToan,
    int? soTrang,
    int? kichThuocTrang) : IQuery;
