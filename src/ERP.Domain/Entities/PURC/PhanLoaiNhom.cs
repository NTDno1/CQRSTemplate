using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.PURC;

public class PhanLoaiNhom : SmartEnum<PhanLoaiNhom, string>
{
    public static readonly PhanLoaiNhom Tier1 = new PhanLoaiNhom(nameof(Tier1), "Tier1");
    public static readonly PhanLoaiNhom Tier2 = new PhanLoaiNhom(nameof(Tier2), "Tier2");
    public static readonly PhanLoaiNhom Tier3 = new PhanLoaiNhom(nameof(Tier3), "Tier3");
    public static readonly PhanLoaiNhom KhongPhanLoai = new PhanLoaiNhom(nameof(KhongPhanLoai), "Không phân loại");

    private PhanLoaiNhom(string name, string value) : base(name, value) { }
}
