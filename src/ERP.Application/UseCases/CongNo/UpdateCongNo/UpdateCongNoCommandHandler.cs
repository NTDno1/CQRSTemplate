using ERP.Domain.Abstractions.Repositories;
using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.UpdateCongNo;
public sealed class UpdateCongNoCommandHandler : ICommandHandler<UpdateCongNoCommand>
{
    private readonly ICongNoRepository _congnoRepository;
    private readonly IRepositoryBase<CongNoSRComment, Ulid> _congnoCommentRepository;
    public UpdateCongNoCommandHandler(ICongNoRepository congnoRepository, IRepositoryBase<CongNoSRComment, Ulid> congnoCommentRepository)
    {
        _congnoRepository = congnoRepository;
        _congnoCommentRepository = congnoCommentRepository;
    }
    public async Task<Result> Handle(UpdateCongNoCommand request, CancellationToken cancellationToken)
    {
        CongNoSR congNoSR = await _congnoRepository.FindByIdAsync(request.Id, cancellationToken);
        if (congNoSR == null)
        {
            return Result.Failure<string>(new Error("NotFound", "Không tìm thấy công nợ!"));
        }
        congNoSR.Update(request.IdKhachHang, request.SoTienHenThanhToan, request.KetQuaThuHoi);

        var addComment = CongNoSRComment.Create(
            congNoSR.Id,
            request.saleComment,
            request.acctComment,
            request.KetQuaThuHoi);
        await _congnoCommentRepository.Add(addComment);

        return Result.Success("Cập nhật thành công");
    }
}
