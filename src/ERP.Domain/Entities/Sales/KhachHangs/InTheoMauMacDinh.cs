using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang;

public class InTheoMauMacDinh : SmartEnum<InTheoMauMacDinh, string>
{
    public static readonly InTheoMauMacDinh HOPLONG = new InTheoMauMacDinh(nameof(HOPLONG), "HOPLONG");
    public static readonly InTheoMauMacDinh TAHCM = new InTheoMauMacDinh(nameof(TAHCM), "TAHCM");
    public static readonly InTheoMauMacDinh GIGA = new InTheoMauMacDinh(nameof(GIGA), "GIGA");


    private InTheoMauMacDinh(string name, string value) : base(name, value) { }
}
