using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang.HopDong;



public class TrangThai : SmartEnum<TrangThai, string>
{
    public static readonly TrangThai DaLuuTruHopDong = new TrangThai(nameof(DaLuuTruHopDong), "Đã lưu trữ hợp đồng");


    private TrangThai(string name, string value) : base(name, value) { }
}
