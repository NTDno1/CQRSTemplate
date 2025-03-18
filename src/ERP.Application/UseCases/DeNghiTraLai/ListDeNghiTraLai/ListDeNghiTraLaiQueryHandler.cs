using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.DeNghiTraLai.ListDeNghiTraLai;
internal class ListDeNghiTraLaiQueryHandler : IQueryHandler<ListDeNghiTraLaiQuery>
{
    private readonly IDeNghiTraLaiRepository _deNghiTraLaiRepository;

    public ListDeNghiTraLaiQueryHandler(IDeNghiTraLaiRepository deNghiTraLaiRepository)
    {
        _deNghiTraLaiRepository = deNghiTraLaiRepository;
    }

    public async Task<Result> Handle(ListDeNghiTraLaiQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;
        IEnumerable<Share.Responses.DeNghiTraLaiRespone.DeNghiTraLaiRespone> deNghiTraLai = await _deNghiTraLaiRepository.GetListDeNghiTraLai(
            tuNgay,
            denNgay,
            request.maDeNghi,
            request.soTrang > 0 ? request.soTrang : 1,
            request.kichThuocTrang > 0 ? request.kichThuocTrang : 10);
        int count = await _deNghiTraLaiRepository.CountListDeNghiTraLai(tuNgay, denNgay, request.maDeNghi);
        var pagedResult = new PagedResult
        {
            Items = deNghiTraLai,
            Total = count,
            PageNumber = request.soTrang ?? 1,
        };

        return Result.Success(pagedResult);
    }
}
