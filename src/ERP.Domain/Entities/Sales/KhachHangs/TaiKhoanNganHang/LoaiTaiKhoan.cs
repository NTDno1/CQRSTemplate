using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang.TaiKhoanNganHang;


public class LoaiTaiKhoan : SmartEnum<LoaiTaiKhoan, string>
{
    public static readonly LoaiTaiKhoan TrongNuoc = new LoaiTaiKhoan(nameof(TrongNuoc), "Trong nước");
    public static readonly LoaiTaiKhoan NuocNgoai = new LoaiTaiKhoan(nameof(NuocNgoai), "Nước ngoài");

    private LoaiTaiKhoan(string name, string value) : base(name, value) { }
}
