using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.UseCases.ChuyenKhos.CreateWhChuyenKho;
using ERP.Share.Extensions;
using FluentValidation;

namespace ERP.Application.UseCases.CongNo.CreateCongNo;
public class CreateCongNoValidator : AbstractValidator<CreateCongNoCommand>
{
    public CreateCongNoValidator()
    {
        RuleFor(x => x.tungay)
            .Must(x => DateExtensions.IsValidDate(x))
            .When(x => !string.IsNullOrWhiteSpace(x.tungay))
            .WithMessage("Từ ngày cần phải ở định dạng dd/MM/yyyy HH:mm:ss.");
        RuleFor(x => x.denngay)
           .Must(x => DateExtensions.IsValidDate(x))
           .When(x => !string.IsNullOrWhiteSpace(x.denngay))
           .WithMessage("Đến ngày cần phải ở định dạng dd/MM/yyyy HH:mm:ss.");
    }
}
