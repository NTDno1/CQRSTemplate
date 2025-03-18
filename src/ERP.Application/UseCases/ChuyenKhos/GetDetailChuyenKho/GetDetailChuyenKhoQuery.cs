using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.WhChuyenKhos.GetWhChuyenKho;
public sealed record GetWhChuyenKhoQuery(
     string idChuyenKho
    ) : IQuery;
