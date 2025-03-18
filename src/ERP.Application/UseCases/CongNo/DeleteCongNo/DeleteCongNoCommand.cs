using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.DeleteCongNo;
public sealed record DeleteCongNoCommand
(
    Ulid Id
) : ICommand;
