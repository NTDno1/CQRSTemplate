using FluentValidation;

namespace ERP.Application.UseCases.KhachHang.KhachHangDetail;
public class DetailKhachHangValidator : AbstractValidator<DetailKhachHangQuery>
{
    public DetailKhachHangValidator()
    {
        RuleFor(x => x.IdKhachHang)
          .NotNull().WithMessage("IdKhachHang không được null.")
          .NotEmpty().WithMessage("IdKhachHang không được để trống.");
    }
}
