using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.BaoGias.BaoGia;



public class KhaNangTrung : SmartEnum<KhaNangTrung, string>
{
    public static readonly KhaNangTrung Cao = new KhaNangTrung(nameof(Cao), "Cao");
    public static readonly KhaNangTrung Thap = new KhaNangTrung(nameof(Thap), "Thấp");
    public static readonly KhaNangTrung TrungBinh = new KhaNangTrung(nameof(TrungBinh), "Trung bình");

    private KhaNangTrung(string name, string value) : base(name, value) { }
}
