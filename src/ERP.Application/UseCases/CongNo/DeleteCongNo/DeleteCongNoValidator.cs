using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ERP.Application.UseCases.CongNo.DeleteCongNo;
public class DeleteCongNoValidator : AbstractValidator<DeleteCongNoCommand>
{
    public DeleteCongNoValidator()
    {
        RuleFor(x => x.Id)
       .NotNull().WithMessage("Mã số công nợ không được null.")
       .NotEmpty().WithMessage("Mã số công nợ không được để trống.");
    }
}
