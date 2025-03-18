using FluentValidation;

namespace ERP.Application.UseCases.WhChuyenKhos.DeleteWhChuyenKho;
public class DeleteChuyenKhoValidator : AbstractValidator<DeleteChuyenKhoCommand>
{
    public DeleteChuyenKhoValidator()
    {
        RuleFor(x => x.idChuyenKho)
           .NotNull().WithMessage("Không tìm thấy Id")
           .NotEmpty().WithMessage("Không tìm thấy Id");
    }
}
