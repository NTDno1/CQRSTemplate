using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiTraLai.DeleteDeNghiTraLai;
internal class DeleteDeNghiTraLaiCommandHandler : ICommandHandler<DeleteDeNghiTraLaiCommand>
{
    private readonly IDeNghiTraLaiRepository _deNghiTraLaiRepository;

    public DeleteDeNghiTraLaiCommandHandler(IDeNghiTraLaiRepository deNghiTraLaiRepository)
    {
        _deNghiTraLaiRepository = deNghiTraLaiRepository;
    }

    public async Task<Result> Handle(DeleteDeNghiTraLaiCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Sales.DeNghi.DeNghiTraLai.DeNghiTraLai baoGia = await _deNghiTraLaiRepository.FindByIdAsync(request.idDeNghi, cancellationToken, u => u.DeNghiTraLaiChiTiets);
        if (baoGia != null)
        {
            _deNghiTraLaiRepository.Remove(baoGia);
            return Result.Success($"Xóa thành công phiếu {baoGia.Id}");
        }
        else
        {
            Error err = new Error("BadRequest", $"Không thể xóa phiếu: {request.idDeNghi}!");
            return Result.Failure(err);
        }
    }
}
