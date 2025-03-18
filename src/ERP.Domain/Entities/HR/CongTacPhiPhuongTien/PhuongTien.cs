using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.HR.CongTacPhiPhuongTien;
public sealed class PhuongTien : SmartEnum<PhuongTien, string>
{
    public static readonly PhuongTien XeMay = new PhuongTien(nameof(XeMay), "Xe máy");
    public static readonly PhuongTien XeOto = new PhuongTien(nameof(XeOto), "Xe Oto");

    private PhuongTien(string name, string value) : base(name, value) { }
}
