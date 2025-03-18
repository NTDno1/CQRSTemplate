using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.WareHouses.NhapKho;
public class LoaiNhapKho : SmartEnum<LoaiNhapKho, string>
{
    public static readonly LoaiNhapKho NhapKhoMuaHangNCC = new LoaiNhapKho(nameof(NhapKhoMuaHangNCC), "Nhập kho mua hàng NCC");
    public static readonly LoaiNhapKho NhapKhoHangBanTraLai = new LoaiNhapKho(nameof(NhapKhoHangBanTraLai), "Nhập kho hàng bán trả lại");
    public static readonly LoaiNhapKho NhapKhoKhac = new LoaiNhapKho(nameof(NhapKhoKhac), "Nhập kho khác");
    private LoaiNhapKho(string name, string value) : base(name, value) { }
}
