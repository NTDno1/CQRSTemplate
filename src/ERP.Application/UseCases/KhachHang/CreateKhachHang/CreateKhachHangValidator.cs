using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Share.Extensions;
using FluentValidation;

namespace ERP.Application.UseCases.KhachHang.CreateKhachHang;
public class CreateKhachHangValidator : AbstractValidator<CreateKhachHangCommand>
{
    public CreateKhachHangValidator()
    {
        RuleFor(x => x.HoaDonMacDinh)
            .NotNull()
            .WithMessage("Hóa đơn mặc định không được để trống.");

        RuleFor(x => x.TinhTrangHoatDong).Must(x => EnumExtentions.IsValidSmartEnumValue<TinhTrangHoatDong>(x))
            .WithMessage("Tình trạng hoạt động không hợp lệ.");

        RuleFor(x => x.GhiChuHoaDonMacDinh)
            .MaximumLength(500)
            .WithMessage("Ghi chú hóa đơn không được vượt quá 500 ký tự.");

        RuleFor(x => x.DanhGiaKhachHang)
            .GreaterThanOrEqualTo(0)
            .When(x => x.DanhGiaKhachHang.HasValue)
            .WithMessage("Đánh giá khách hàng phải lớn hơn hoặc bằng 0.");

        RuleFor(x => x.GhiChuCongNo)
            .MaximumLength(500)
            .WithMessage("Ghi chú công nợ không được vượt quá 500 ký tự.");

        RuleFor(x => x.HeThongKhachHang)
            .MaximumLength(100)
            .WithMessage("Hệ thống khách hàng không được vượt quá 100 ký tự.");

        RuleFor(x => x.MangKinhDoanh)
            .MaximumLength(100)
            .WithMessage("Mảng kinh doanh không được vượt quá 100 ký tự.");
    }
}
