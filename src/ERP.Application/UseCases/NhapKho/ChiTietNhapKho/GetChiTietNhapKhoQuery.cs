using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.NhapKho.ChiTietNhapKho;
public sealed record GetChiTietNhapKhoQuery(Ulid id) : IQuery;

