using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.ListCongNoThucTe;
public sealed record ListCongNoThucTeQuery
(
    string? tuNgay,
    string? denNgay,
    int? soTrang,
    int? kichThuocTrang
    ) : IQuery;
