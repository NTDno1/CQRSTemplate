using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiThanhToanCM.ListDeNghiThanhToanCM;
public sealed record ListDNThanhToanCMQuery
(
    string? tuNgay,
    string? denNgay,
    int? soTrang,
    int? kichThuocTrang
) : IQuery;
