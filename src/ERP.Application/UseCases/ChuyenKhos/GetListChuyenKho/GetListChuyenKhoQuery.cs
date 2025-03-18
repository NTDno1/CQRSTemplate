using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.ChuyenKhos.GetListWhChuyenKho;
public sealed record GetListChuyenKhoQuery(
    string? tuNgay,
    string? denNgay,
    string? maChuyenKho,
    int? soTrang,
    int? kichThuocTrang
    ) : IQuery;
