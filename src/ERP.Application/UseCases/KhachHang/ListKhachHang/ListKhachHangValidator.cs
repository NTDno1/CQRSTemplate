using FluentValidation;

namespace ERP.Application.UseCases.KhachHang.ListKhachHang;
public class ListKhachHangValidator : AbstractValidator<ListKhachHangQuery>
{
    public ListKhachHangValidator()
    {
        //RuleFor(x => x.CanXuatHoaDon)
        //  .NotNull().WithMessage("CanXuatHoaDon không được null.")
        //  .NotEmpty().WithMessage("CanXuatHoaDon không được để trống.");
        //RuleForEach(x => x.AddChuyenKhoChiTiets)
        //.ChildRules(chiTiet =>
        //{
        //    chiTiet.RuleFor(c => c.NgayNhatHang)
        //    .Must(x => DateExtensions.IsValidDate(x))
        //    .WithMessage("NgayNhatHang cần phải ở định dạng dd/MM/yyyy HH:mm:ss.");
        //});
    }
}
