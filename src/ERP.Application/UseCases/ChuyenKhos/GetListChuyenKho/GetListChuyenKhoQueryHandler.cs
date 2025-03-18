using ERP.Application.UseCases.ChuyenKhos.GetListWhChuyenKho;
using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;
using ERP.Share.Responses.ChuyenKho;

namespace ERP.Application.UseCases.WhChuyenKhos.GetListWhChuyenKho;
public sealed class GetListChuyenKhoQueryHandler : IQueryHandler<GetListChuyenKhoQuery>
{
    private readonly IChuyenKhoRepository _whChuyenKhoRepository;

    public GetListChuyenKhoQueryHandler(IChuyenKhoRepository whChuyenKhoRepository)
    {
        _whChuyenKhoRepository = whChuyenKhoRepository;
    }

    public async Task<Result> Handle(GetListChuyenKhoQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = request.tuNgay?.ConvertToDate();
        DateTime? denNgay = request.denNgay?.ConvertToDate();
        int? soTrang = request.soTrang > 0 ? request.soTrang : 1;
        int? kichThuocTrang = request.kichThuocTrang > 0 ? request.kichThuocTrang : 10;

        IEnumerable<ChuyenKhoRespone> listWhChuyenKho = await _whChuyenKhoRepository.GetListWhChuyenKho(tuNgay, denNgay, request.maChuyenKho, soTrang, kichThuocTrang);
        int countListWhChuyenKho = await _whChuyenKhoRepository.CountListWhChuyenKho(tuNgay, denNgay, request.maChuyenKho);
        var pagedResult = new PagedResult
        {
            Items = listWhChuyenKho,
            Total = countListWhChuyenKho,
            PageNumber = request.soTrang ?? 1,
        };
        return Result.Success(pagedResult);
    }
}
