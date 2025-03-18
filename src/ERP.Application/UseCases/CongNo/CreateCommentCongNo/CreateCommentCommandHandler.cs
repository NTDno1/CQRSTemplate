using ERP.Domain.Abstractions.Repositories;
using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.CreateCommentCongNo;
public sealed class CreateCommentCommandHandler : ICommandHandler<CreateCommentCommand>
{

    private readonly ICongNoRepository _congnoRepository;
    private readonly IRepositoryBase<CongNoSRComment, Ulid> _congnoCommentRepository;

    public CreateCommentCommandHandler(ICongNoRepository congnoRepository, IRepositoryBase<CongNoSRComment, Ulid> congnoCommentRepository)
    {
        _congnoRepository = congnoRepository;
        _congnoCommentRepository = congnoCommentRepository;
    }

    public async Task<Result> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        CongNoSR congno = await _congnoRepository.FindByIdAsync(request.idCongNo, cancellationToken, u => u.CongNoSRComments);
        if(congno == null)
        {
            return Result.Failure<string>(new Error("NotFound", $"Không tìm thấy công nợ {request.idCongNo}!"));
        }
        var addComment = CongNoSRComment.Create(
            request.idCongNo,
            request.saleComment,
            request.acctComment,
            request.noiDungComment
            )
        ;
        await _congnoCommentRepository.Add(addComment);
        return Result.Success();
    }
}
