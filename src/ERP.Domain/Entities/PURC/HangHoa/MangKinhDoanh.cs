using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.PURC.HangHoa;

public class MangKinhDoanh : SmartEnum<MangKinhDoanh, string>
{
    public static readonly MangKinhDoanh Auto = new MangKinhDoanh(nameof(Auto), "AUTO");
    public static readonly MangKinhDoanh Chung = new MangKinhDoanh(nameof(Chung), "CHUNG");
    public static readonly MangKinhDoanh Giga = new MangKinhDoanh(nameof(Giga), "GIGA");


    private MangKinhDoanh(string name, string value) : base(name, value) { }
}
