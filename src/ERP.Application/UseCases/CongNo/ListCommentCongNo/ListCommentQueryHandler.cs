using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.UseCases.CongNo.ListCongNo;
using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Responses.ChuyenKho;
using ERP.Share.Responses.CongNoResponse;

namespace ERP.Application.UseCases.CongNo.ListCommentCongNo;
public class ListCommentQueryHandler : IQueryHandler<ListCommentQuery>
{
    private readonly ICongNoRepository _congNoRePository;

    public ListCommentQueryHandler(ICongNoRepository congNoRePository)
    {
        _congNoRePository = congNoRePository;
    }
    public async Task<Result> Handle(ListCommentQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<CongNoCommentResponse> congnoComment = await _congNoRePository.ListCongNoComment(request.idCongNo);

        return Result.Success(congnoComment);

    }
}
