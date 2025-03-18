using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.HangHoa.DeleteHangHoa;
public sealed class DeleteHangHoaCommandHandler : ICommandHandler<DeleteHangHoaCommand>
{
    private readonly IHangHoaRepository _hangHoaRepository;

    public DeleteHangHoaCommandHandler(IHangHoaRepository hangHoaRepository)
    {
        _hangHoaRepository = hangHoaRepository;
    }

    public async Task<Result> Handle(DeleteHangHoaCommand request, CancellationToken cancellationToken)
    {

        var hhExist = await _hangHoaRepository.FindByIdAsync(request.IdHangHoa, cancellationToken, x => x.HinhAnhHangHoas);
        if (hhExist == null)
        {
            Error error = new Error("NotFound", $"Không tìm thấy mã hàng với ID {request.IdHangHoa}");
            return Result.Failure(error);
        }
        _hangHoaRepository.Remove(hhExist);
        return Result.Success($"Xóa thành công mã hàng  với ID {request.IdHangHoa}");
    }
}
