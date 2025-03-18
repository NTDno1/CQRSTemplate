using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.DeleteCongNo;
public class DeleteCongNoCommandHandler : ICommandHandler<DeleteCongNoCommand>
{
    private readonly ICongNoRepository _congNoRepository;

    public DeleteCongNoCommandHandler(ICongNoRepository congNoRepository)
    {
        _congNoRepository = congNoRepository;
    }
    public async Task<Result> Handle(DeleteCongNoCommand request, CancellationToken cancellationToken)
    {
        CongNoSR getCongNo = await _congNoRepository.FindByIdAsync(request.Id, cancellationToken, u => u.CongNoSRComments);
        if (getCongNo != null)
        {
            _congNoRepository.Remove(getCongNo);
            return Result.Success($"Xóa thành công công nợ: {getCongNo.Id}");
        }
        Error err = new Error("BadRequest", $"Không thể xóa công nợ: {request.Id}!");
        return Result.Failure(err);
    }
}
