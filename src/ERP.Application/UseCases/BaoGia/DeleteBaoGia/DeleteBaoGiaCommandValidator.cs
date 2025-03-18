using FluentValidation;

namespace ERP.Application.UseCases.BaoGia.DeleteBaoGia;
public class DeleteBaoGiaCommandValidator : AbstractValidator<DeleteBaoGiaCommand>
{
    public DeleteBaoGiaCommandValidator()
    {
        RuleFor(x => x.IdBaoGia)
       .NotNull().WithMessage("IdKhachHang không được null.")
       .NotEmpty().WithMessage("IdKhachHang không được để trống.");
    }
}
