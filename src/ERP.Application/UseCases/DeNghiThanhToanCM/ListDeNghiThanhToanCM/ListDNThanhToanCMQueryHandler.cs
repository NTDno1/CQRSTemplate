using ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;
using ERP.Share.Responses.DeNghiThanhToanCM;

namespace ERP.Application.UseCases.DeNghiThanhToanCM.ListDeNghiThanhToanCM;
public class ListDNThanhToanCMQueryHandler : IQueryHandler<ListDNThanhToanCMQuery>
{
    private readonly IDeNghiThanhToanCMRepository _deNghiThanhToanCMRepository;

    public ListDNThanhToanCMQueryHandler(IDeNghiThanhToanCMRepository deNghiThanhToanCMRepository)
    {
        _deNghiThanhToanCMRepository = deNghiThanhToanCMRepository;
    }
    public async Task<Result> Handle(ListDNThanhToanCMQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        IEnumerable<DeNghiThanhToanCMResponse> listDNTTCM = await _deNghiThanhToanCMRepository.ListDeNghiThanhToanCM(tuNgay, denNgay, request.soTrang > 0 ? request.soTrang : 1, request.kichThuocTrang > 0 ? request.kichThuocTrang : 10);
        int countlistDNTTCM = await _deNghiThanhToanCMRepository.CountDeNghiThanhToanCM(tuNgay, denNgay);
        var pagedResult = new PagedResult
        {
            Items = listDNTTCM,
            Total = countlistDNTTCM,
            PageNumber = request.soTrang ?? 1,
        };
        return Result.Success(pagedResult);
    }
}
