using ERP.Application.UseCases.ChuyenKhos.CreateWhChuyenKho;
using ERP.Share.Extensions;
using FluentValidation;

namespace ERP.Application.UseCases.KhoChuyenKhos.CreateKhoChuyenKho;
public class CreateChuyenKhoValidator : AbstractValidator<CreateChuyenKhoCommand>
{
    public CreateChuyenKhoValidator()
    {
        RuleFor(x => x.ThoiGianNhanHang)
            .Must(x => DateExtensions.IsValidDate(x))
            .When(x => !string.IsNullOrWhiteSpace(x.ThoiGianNhanHang))
            .WithMessage("ThoiGianNhanHang cần phải ở định dạng dd/MM/yyyy HH:mm:ss.");
        RuleFor(x => x.NgayXacNhanXuat)
           .Must(x => DateExtensions.IsValidDate(x))
           .When(x => !string.IsNullOrWhiteSpace(x.NgayXacNhanXuat))
           .WithMessage("NgayXacNhanXuat cần phải ở định dạng dd/MM/yyyy HH:mm:ss.");
        //RuleFor(x => x.CanXuatHoaDon)
        //  .NotNull().WithMessage("CanXuatHoaDon không được null.")
        //  .NotEmpty().WithMessage("CanXuatHoaDon không được để trống.");
        RuleForEach(x => x.AddChuyenKhoChiTiets)
        .ChildRules(chiTiet =>
        {
            chiTiet.RuleFor(c => c.NgayNhatHang)
            .Must(x => DateExtensions.IsValidDate(x))
            .WithMessage("NgayNhatHang cần phải ở định dạng dd/MM/yyyy HH:mm:ss.");
        });
        RuleForEach(x => x.AddChuyenKhoChiTiets)
        .ChildRules(chiTiet =>
        {
            chiTiet.RuleFor(c => c.SoLuong)
             .NotNull().WithMessage("SoLuong không được null.")
            .NotEmpty().WithMessage("SoLuong không được để trống.");
        });
        RuleForEach(x => x.AddChuyenKhoChiTiets)
        .ChildRules(chiTiet =>
        {
            chiTiet.RuleFor(c => c.DonGia)
             .NotNull().WithMessage("DonGia không được null.")
            .NotEmpty().WithMessage("DonGia không được để trống.");
        });
        RuleForEach(x => x.AddChuyenKhoChiTiets)
        .ChildRules(chiTiet =>
        {
            chiTiet.RuleFor(c => c.ThanhTien)
             .NotNull().WithMessage("ThanhTien không được null.")
            .NotEmpty().WithMessage("ThanhTien không được để trống.");
        });
        RuleForEach(x => x.AddChuyenKhoChiTiets)
        .ChildRules(chiTiet =>
        {
            chiTiet.RuleFor(c => c.SoLuongDaNhat)
             .NotNull().WithMessage("SoLuongDaNhat không được null.")
            .NotEmpty().WithMessage("SoLuongDaNhat không được để trống.");
        });
    }
}
