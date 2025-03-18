using FluentValidation;

namespace ERP.Application.UseCases.BaoGia.CreateBaoGia;
public class CreateBaoGiaValidator : AbstractValidator<CreateBaoGiaCommand>
{
    public CreateBaoGiaValidator()
    {
        RuleFor(x => x.NgayBaoGia)
             .NotEmpty()
             .WithMessage("Ngày Báo Giá không được để trống.");

        RuleFor(x => x.IdKhachHang)
            .NotEmpty()
            .WithMessage("IdKhachHang không được để trống.");

        RuleFor(x => x.IdLienHe)
            .NotEmpty();

        RuleFor(x => x.HieuLucBaoGia)
            .GreaterThan(0)
            .WithMessage("HieuLucBaoGia phải lớn hơn 0.");

        //RuleFor(x => x.IdDieuKhoanThanhToan)
        //    .GreaterThan(0)
        //    .WithMessage("IdDieuKhoanThanhToan phải lớn hơn 0.");

        //RuleFor(x => x.IdDieuKhoanThanhToanKhachHang)
        //    .GreaterThan(0)
        //    .WithMessage("IdDieuKhoanThanhToanKhachHang phải lớn hơn 0.");

        RuleFor(x => x.ThanhTienNet)
            .GreaterThan(0)
            .WithMessage("ThanhTienNet phải lớn hơn 0.");

        RuleFor(x => x.TongThanhTien)
            .GreaterThan(0)
            .WithMessage("TongThanhTien phải lớn hơn 0.");

        //RuleFor(x => x.LoaiDon)
        //    .Must(x => Enum.IsDefined(typeof(LoaiDon), x))
        //    .WithMessage("LoaiDon không hợp lệ.");

        //RuleFor(x => x.TrangThaiDon)
        //    .Must(x => Enum.IsDefined(typeof(TrangThaiDon), x))
        //    .WithMessage("TrangThaiDon không hợp lệ.");

        RuleFor(x => x.DiaChiGiaoHang)
            .MaximumLength(500)
            .WithMessage("DiaChiGiaoHang không được vượt quá 500 ký tự.");

        RuleFor(x => x.NguoiNhanHang)
            .MaximumLength(100)
            .WithMessage("NguoiNhanHang không được vượt quá 100 ký tự.");
    }
}
