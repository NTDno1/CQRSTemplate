using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.WhChuyenKhos.DeleteWhChuyenKho;
public sealed class DeleteChuyenKhoCommandHandler : ICommandHandler<DeleteChuyenKhoCommand>
{
    private readonly IChuyenKhoRepository _whChuyenKhoRepository;

    public DeleteChuyenKhoCommandHandler(IChuyenKhoRepository whChuyenKhoRepository)
    {
        _whChuyenKhoRepository = whChuyenKhoRepository;
    }

    public async Task<Result> Handle(DeleteChuyenKhoCommand request, CancellationToken cancellationToken)
    {
        ChuyenKho getchuyenkho = await _whChuyenKhoRepository.FindByIdAsync(request.idChuyenKho, cancellationToken, u => u.ChuyenKhoChiTiets);
        if (getchuyenkho != null && getchuyenkho.TrangThai == "Chờ nhặt hàng")
        {
            _whChuyenKhoRepository.Remove(getchuyenkho);
            return Result.Success($"Xóa thành công phiếu {getchuyenkho.Id}");
        }
        else
        {
            Error err = new Error("BadRequest", $"Không thể xóa phiếu: {getchuyenkho.Id}!");
            return Result.Failure(err);
        }
    }
}
