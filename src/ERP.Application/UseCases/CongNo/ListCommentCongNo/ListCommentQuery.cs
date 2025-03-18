using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.ListCommentCongNo;
public sealed record ListCommentQuery(
    Ulid idCongNo
    ) : IQuery;
