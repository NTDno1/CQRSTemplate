using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Shared;


public sealed class TrucThuoc : SmartEnum<TrucThuoc, string>
{
    public static readonly TrucThuoc HOPLONG = new TrucThuoc(nameof(HOPLONG), "HOPLONG");
    public static readonly TrucThuoc GIGA = new TrucThuoc(nameof(GIGA), "GIGA");
    public static readonly TrucThuoc TAHP = new TrucThuoc(nameof(TAHP), "TAHP");
    public static readonly TrucThuoc TADN = new TrucThuoc(nameof(TADN), "TADN");
    public static readonly TrucThuoc TAHCM = new TrucThuoc(nameof(TAHCM), "TAHCM");

    private TrucThuoc(string name, string value) : base(name, value) { }
}
