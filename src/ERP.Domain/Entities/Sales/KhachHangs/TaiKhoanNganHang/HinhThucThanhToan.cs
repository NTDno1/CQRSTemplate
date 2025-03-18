using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang.TaiKhoanNganHang;


public class HinhThucThanhToan : SmartEnum<HinhThucThanhToan, string>
{
    public static readonly HinhThucThanhToan CaNhan = new HinhThucThanhToan(nameof(CaNhan), "Cá nhân");
    public static readonly HinhThucThanhToan CongTy = new HinhThucThanhToan(nameof(CongTy), "Công ty");

    private HinhThucThanhToan(string name, string value) : base(name, value) { }
}
