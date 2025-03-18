using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.BaoGia.DeleteBaoGia;
public class DeleteBaoGiaCommandHandler : ICommandHandler<DeleteBaoGiaCommand>
{
    private readonly IBaoGiaRepository _baoGiaRepository;

    public DeleteBaoGiaCommandHandler(IBaoGiaRepository baoGiaRepository)
    {
        _baoGiaRepository = baoGiaRepository;
    }

    public async Task<Result> Handle(DeleteBaoGiaCommand request, CancellationToken cancellationToken)
    {
        ERP.Domain.Entities.Sales.BaoGias.BaoGia.BaoGia baoGia = await _baoGiaRepository.FindByIdAsync(request.IdBaoGia, cancellationToken, u => u.BaoGiaChiTiets);
        if (baoGia != null)
        {
            _baoGiaRepository.Remove(baoGia);
            return Result.Success($"Xóa thành công phiếu {baoGia.Id}");
        }
        else
        {
            Error err = new Error("BadRequest", $"Không thể xóa phiếu: {request.IdBaoGia}!");
            return Result.Failure(err);
        }
    }
}
