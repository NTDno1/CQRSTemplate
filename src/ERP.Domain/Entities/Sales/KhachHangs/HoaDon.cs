using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang;
public class HoaDon : SmartEnum<HoaDon, string>
{
    public static readonly HoaDon HoaDonDienTu = new HoaDon(nameof(HoaDonDienTu), "Hóa đơn điện tử");
    public static readonly HoaDon HoaDonDienTuSau = new HoaDon(nameof(HoaDonDienTuSau), "Hóa đơn điện tử sau");

    private HoaDon(string name, string value) : base(name, value) { }
}
