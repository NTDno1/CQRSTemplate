using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.KhachHang.DeleteKhachHang;
public class DeleteKhachHangCommandHandler : ICommandHandler<DeleteKhachHangCommand>
{
    private readonly IKhachHangRepository _khachHangRepository;

    public DeleteKhachHangCommandHandler(IKhachHangRepository khachHangRepository)
    {
        _khachHangRepository = khachHangRepository;
    }

    public async Task<Result> Handle(DeleteKhachHangCommand request, CancellationToken cancellationToken)
    {
        ERP.Domain.Entities.Sales.KhachHang.KhachHang getKhachHang = await _khachHangRepository.FindByIdAsync(request.IdKhachHang, cancellationToken);
        if (getKhachHang != null)
        {
            _khachHangRepository.Remove(getKhachHang);
            return Result.Success($"Xóa thành công khách hàng: {request.IdKhachHang}");
        }
        Error err = new Error("BadRequest", $"Không thể xóa khách hàng: {request.IdKhachHang}!");
        return Result.Failure(err);
    }
}
