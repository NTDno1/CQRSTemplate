using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang;

public class VendorStatus : SmartEnum<VendorStatus, string>
{
    public static readonly VendorStatus ChuaCoCode = new VendorStatus(nameof(ChuaCoCode), "Cần code nhà máy - Chưa có code");
    public static readonly VendorStatus DaCoCode = new VendorStatus(nameof(DaCoCode), "Cần code nhà máy - Đã có code");
    public static readonly VendorStatus KhongCanCode = new VendorStatus(nameof(KhongCanCode), "Không cần code nhà máy");


    private VendorStatus(string name, string value) : base(name, value) { }
}
