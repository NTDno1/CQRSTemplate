using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang.HopDong;

public class LoaiHopDong : SmartEnum<LoaiHopDong, string>
{
    public static readonly LoaiHopDong HopDongNguyenTac = new LoaiHopDong(nameof(HopDongNguyenTac), "Hợp đồng nguyên tắc");


    private LoaiHopDong(string name, string value) : base(name, value) { }
}
