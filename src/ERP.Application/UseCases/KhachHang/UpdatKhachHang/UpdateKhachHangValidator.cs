using FluentValidation;

namespace ERP.Application.UseCases.KhachHang.UpdatKhachHang;

public class UpdateKhachHangValidator : AbstractValidator<UpdateKhachHangCommand>
{
    public UpdateKhachHangValidator()
    {
        RuleFor(x => x.TenCongTy)
                .NotEmpty()
                .When(x => !string.IsNullOrEmpty(x.TenCongTy))
                .WithMessage("Username của leader không tồn tại!");
        //RuleFor(x => x.TaiKhoanNganHang.LoaiTaiKhoan)
        //    .Must(EnumExtentions.IsValidSmartEnumValue<LoaiTaiKhoan>)
        //    .WithMessage("Mảng kinh doanh không phù hợp!");
        //RuleFor(x => x.HoaDonMacDinh)
        //    .NotNull()
        //    .WithMessage("HoaDonMacDinh không được để trống.");

        //RuleFor(x => x.IDDieuKhoanThanhToan)
        //    .GreaterThan(0)
        //    .WithMessage("IDDieuKhoanThanhToan phải lớn hơn 0.");

        //RuleFor(x => x.IDDieuKhoanThanhToanNoiBo)
        //    .GreaterThan(0)
        //    .WithMessage("IDDieuKhoanThanhToanNoiBo phải lớn hơn 0.");

        //RuleFor(x => x.TinhTrangHoatDong).Must(x => EnumExtentions.IsValidSmartEnumValue<TinhTrangHoatDong>(x))
        //    .WithMessage("TinhTrangHoatDong không hợp lệ.");

        //RuleFor(x => x.GhiChuHoaDonMacDinh)
        //    .MaximumLength(500)
        //    .WithMessage("GhiChuHoaDonMacDinh không được vượt quá 500 ký tự.");

        //RuleFor(x => x.DanhGiaKhachHang)
        //    .GreaterThanOrEqualTo(0)
        //    .When(x => x.DanhGiaKhachHang.HasValue)
        //    .WithMessage("DanhGiaKhachHang phải lớn hơn hoặc bằng 0.");

        //RuleFor(x => x.GhiChuCongNo)
        //    .MaximumLength(500)
        //    .WithMessage("GhiChuCongNo không được vượt quá 500 ký tự.");

        //RuleFor(x => x.HeThongKhachHang)
        //    .MaximumLength(100)
        //    .WithMessage("HeThongKhachHang không được vượt quá 100 ký tự.");

        //RuleFor(x => x.MangKinhDoanh)
        //    .MaximumLength(100)
        //    .WithMessage("MangKinhDoanh không được vượt quá 100 ký tự.");
    }
}
