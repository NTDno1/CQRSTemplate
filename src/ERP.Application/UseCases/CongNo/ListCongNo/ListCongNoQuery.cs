using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.ListCongNo;
public sealed record ListCongNoQuery(
    string? tuNgay,
    string? denNgay,
    int? soTrang,
    int? kichThuocTrang
    ) : IQuery;

