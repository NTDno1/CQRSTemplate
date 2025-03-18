using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.HangHoa.GetHangHoa;
public sealed class GetHangHoaQueryHandler : IQueryHandler<GetHangHoaQuery>
{
    private readonly IHangHoaRepository _hangHoaRepository;

    public GetHangHoaQueryHandler(IHangHoaRepository hangHoaRepository)
    {
        _hangHoaRepository = hangHoaRepository;
    }

    public async Task<Result> Handle(GetHangHoaQuery request, CancellationToken cancellationToken)
    {
        var res = await _hangHoaRepository.FindByIdAsync(request.IdHangHoa);
        return Result.Success(res);
    }


}
