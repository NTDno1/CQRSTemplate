using ERP.Domain.Entities.Sales.DeNghi.DeNghiSuaGia;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.DeNghiSuaGia.ListDeNghiSuaGia;
internal class ListDeNghiSuaGiaQueryHandler : IQueryHandler<ListDeNghiSuaGiaQuery>
{
    private readonly IDeNghiSuaGiaRepository _deNghiSuaGiaRepository;

    public ListDeNghiSuaGiaQueryHandler(IDeNghiSuaGiaRepository deNghiSuaGiaRepository)
    {
        _deNghiSuaGiaRepository = deNghiSuaGiaRepository;
    }

    public async Task<Result> Handle(ListDeNghiSuaGiaQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        IEnumerable<Share.Responses.DeNghiSuaGiaRespone.DeNghiSuaGiaRespone> deNghiSuaGiaRespones = await _deNghiSuaGiaRepository.GetListDeNghiSuaGia(
            tuNgay,
            denNgay,
            request.maChuan,
            request.soTrang > 0 ? request.soTrang : 1,
            request.kichThuocTrang > 0 ? request.kichThuocTrang : 10);

        int countListDeNghiSuaGia = await _deNghiSuaGiaRepository.CountListDeNghiSuaGia(
            tuNgay,
            denNgay,
            request.maChuan);
        var pagedResult = new PagedResult
        {
            Items = deNghiSuaGiaRespones,
            Total = countListDeNghiSuaGia,
            PageNumber = request.soTrang ?? 1,
        };
        return Result.Success(pagedResult);
    }
}
