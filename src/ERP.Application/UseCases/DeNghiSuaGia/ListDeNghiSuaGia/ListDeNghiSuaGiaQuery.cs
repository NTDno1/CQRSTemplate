using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiSuaGia.ListDeNghiSuaGia;
public sealed record ListDeNghiSuaGiaQuery(
    string? tuNgay,
    string? denNgay,
    string? maChuan,
    int? soTrang,
    int? kichThuocTrang) : IQuery;
