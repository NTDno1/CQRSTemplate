using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiThanhToanCM.DeleteDeNghiThanhToanCM;
public class DeleteDNThanhToanCMCommandHandler : ICommandHandler<DeleteDNThanhToanCMCommand>
{
    private readonly IDeNghiThanhToanCMRepository _deNghiThanhToanCMRepository;

    public DeleteDNThanhToanCMCommandHandler(IDeNghiThanhToanCMRepository deNghiThanhToanCMRepository)
    {
        _deNghiThanhToanCMRepository = deNghiThanhToanCMRepository;
    }
    public async Task<Result> Handle(DeleteDNThanhToanCMCommand request, CancellationToken cancellationToken)
    {
        ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM.DeNghiThanhToanCM dnttCM = await _deNghiThanhToanCMRepository.FindByIdAsync(request.Id, cancellationToken);
        if (dnttCM != null)
        {
            _deNghiThanhToanCMRepository.Remove(dnttCM);
            return Result.Success($"Xóa thành công đề nghị: {dnttCM.Id}");
        }
        Error err = new Error("BadRequest", $"Không thể xóa đề nghị: {request.Id}!");
        return Result.Failure(err);
    }
}
