using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.UseCases.CongNo.ListCongNo;
using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;
using ERP.Share.Responses.CongNoResponse;

namespace ERP.Application.UseCases.CongNo.ListCongNoThucTe;
public class ListCongNoThucTeQueryHandler : IQueryHandler<ListCongNoThucTeQuery>
{
    private readonly ICongNoRepository _congNoRepository;

    public ListCongNoThucTeQueryHandler(ICongNoRepository congNoRepository)
    {
        _congNoRepository = congNoRepository;
    }

    public async Task<Result> Handle(ListCongNoThucTeQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        IEnumerable<CongNoThucTeResponse> listCongNo = await _congNoRepository.ListCongNoThucTe(tuNgay, denNgay, request.soTrang > 0 ? request.soTrang : 1, request.kichThuocTrang > 0 ? request.kichThuocTrang : 10);
        int countListCongNo = await _congNoRepository.CountListCongNoThucTe(tuNgay, denNgay);
        var pagedResult = new PagedResult
        {
            Items = listCongNo,
            Total = countListCongNo,
            PageNumber = request.soTrang ?? 1,
        };
        return Result.Success(pagedResult);
    }
}
