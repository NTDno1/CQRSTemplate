using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiTraLai.DetailDeNghiTraLai;
public sealed record DetailDeNghiTraLaiQuery(
    string idDeNghi) : IQuery;
