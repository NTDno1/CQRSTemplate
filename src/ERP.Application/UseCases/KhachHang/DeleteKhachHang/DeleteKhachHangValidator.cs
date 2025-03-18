using FluentValidation;

namespace ERP.Application.UseCases.KhachHang.DeleteKhachHang;
public class DeleteKhachHangValidator : AbstractValidator<DeleteKhachHangCommand>
{
    public DeleteKhachHangValidator()
    {
        RuleFor(x => x.IdKhachHang)
       .NotNull().WithMessage("Mã khách hàng không được null.")
       .NotEmpty().WithMessage("Mã khách hàng không được để trống.");
    }
}
