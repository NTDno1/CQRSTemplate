using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.UseCases.BaoGia.UpdateBaoGia;
using FluentValidation;

namespace ERP.Application.UseCases.CongNo.UpdateCongNo;
public class UpdateCongNoValidator : AbstractValidator<UpdateCongNoCommand>
{
    public UpdateCongNoValidator()
    {
        RuleFor(x => x.KetQuaThuHoi)
             .NotEmpty()
             .WithMessage("Phản hồi không được để trống.");
    }
}
