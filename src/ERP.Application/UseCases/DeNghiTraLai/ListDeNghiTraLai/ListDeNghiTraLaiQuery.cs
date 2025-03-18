using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiTraLai.ListDeNghiTraLai;
public sealed record ListDeNghiTraLaiQuery(
    string? tuNgay,
    string? denNgay,
    string? maDeNghi,
    int? soTrang,
    int? kichThuocTrang) : IQuery;
