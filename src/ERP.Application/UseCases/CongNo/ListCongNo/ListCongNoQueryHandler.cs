using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;
using ERP.Share.Responses.CongNoResponse;

namespace ERP.Application.UseCases.CongNo.ListCongNo;
public class ListCongNoQueryHandler : IQueryHandler<ListCongNoQuery>
{
    private readonly ICongNoRepository _congNoRePository;

    public ListCongNoQueryHandler(ICongNoRepository congNoRePository)
    {
        _congNoRePository = congNoRePository;
    }

    public async Task<Result> Handle(ListCongNoQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        IEnumerable<CongNoResponse> listCongNo = await _congNoRePository.ListCongNo(tuNgay, denNgay, request.soTrang > 0 ? request.soTrang : 1, request.kichThuocTrang > 0 ? request.kichThuocTrang : 10);
        int countListCongNo = await _congNoRePository.CountListCongNo(tuNgay, denNgay);
        var pagedResult = new PagedResult
        {
            Items = listCongNo,
            Total = countListCongNo,
            PageNumber = request.soTrang ?? 1,
        };
        return Result.Success(pagedResult);
    }
}
