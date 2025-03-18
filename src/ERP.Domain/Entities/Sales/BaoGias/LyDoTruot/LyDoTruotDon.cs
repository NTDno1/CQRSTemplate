using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.BaoGias.LyDoTruot;

public class LyDoTruotDon : SmartEnum<LyDoTruotDon, string>
{
    public static readonly LyDoTruotDon DuAnPhiaKhachHangTamHoan = new LyDoTruotDon(nameof(DuAnPhiaKhachHangTamHoan), "Do dự án phía khách hàng tạm hoãn");
    public static readonly LyDoTruotDon KhongCoSanHang = new LyDoTruotDon(nameof(KhongCoSanHang), "Trượt đơn hàng do không có sẵn");
    public static readonly LyDoTruotDon KhongDapUngThoiGian = new LyDoTruotDon(nameof(KhongDapUngThoiGian), "Thời gian không đáp ứng");
    public static readonly LyDoTruotDon KhachHuongCMTuBenKhac = new LyDoTruotDon(nameof(KhachHuongCMTuBenKhac), "Do khách hàng hưởng CM từ bên khác");
    public static readonly LyDoTruotDon Khac = new LyDoTruotDon(nameof(Khac), "Khác");


    private LyDoTruotDon(string name, string value) : base(name, value) { }
}
