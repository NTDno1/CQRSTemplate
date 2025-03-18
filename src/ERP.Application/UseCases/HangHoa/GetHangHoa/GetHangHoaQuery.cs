using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.HangHoa.GetHangHoa;
public sealed record GetHangHoaQuery(string TuNgay, string DenNgay, Ulid IdHangHoa, int PageNumber, int PageSize) : IQuery;

