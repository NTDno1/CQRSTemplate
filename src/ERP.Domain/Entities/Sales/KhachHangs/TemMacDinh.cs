using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang;


public class TemMacDinh : SmartEnum<TemMacDinh, string>
{
    public static readonly TemMacDinh TemCongTy = new TemMacDinh(nameof(TemCongTy), "Tem công ty");
    public static readonly TemMacDinh TemThuongMai = new TemMacDinh(nameof(TemThuongMai), "Tem thương mại");
    public static readonly TemMacDinh KhongDanTem = new TemMacDinh(nameof(KhongDanTem), "Không dán tem");


    private TemMacDinh(string name, string value) : base(name, value) { }
}
