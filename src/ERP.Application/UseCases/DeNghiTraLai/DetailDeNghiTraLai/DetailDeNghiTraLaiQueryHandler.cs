using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiTraLai.DetailDeNghiTraLai;
internal class DetailDeNghiTraLaiQueryHandler : IQueryHandler<DetailDeNghiTraLaiQuery>
{
    private readonly IDeNghiTraLaiRepository _deNghiTraLaiRepository;

    public DetailDeNghiTraLaiQueryHandler(IDeNghiTraLaiRepository deNghiTraLaiRepository)
    {
        _deNghiTraLaiRepository = deNghiTraLaiRepository;
    }

    public async Task<Result> Handle(DetailDeNghiTraLaiQuery request, CancellationToken cancellationToken)
    {
        Share.Responses.DeNghiTraLaiRespone.DetailDeNghiTraLaiRespone deNghiTraLai = await _deNghiTraLaiRepository.GetDeNghiTraLai(request.idDeNghi);
        IEnumerable<Share.Responses.DeNghiTraLaiRespone.DeNghiTraLaiChiTietRespone> deNghiTraLaiChiTiet = await _deNghiTraLaiRepository.GetDeNghiTraLaiChiTiet(request.idDeNghi);
        deNghiTraLai.DeNghiTraLaiChiTiet = deNghiTraLaiChiTiet;
        return Result.Success(deNghiTraLai);
    }
}
