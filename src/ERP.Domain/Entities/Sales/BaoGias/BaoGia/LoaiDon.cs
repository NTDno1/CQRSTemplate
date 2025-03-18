using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.BaoGias.BaoGia;


public class LoaiDon : SmartEnum<LoaiDon, string>
{
    public static readonly LoaiDon DonSaleTuKiem = new LoaiDon(nameof(DonSaleTuKiem), "Đơn sale tự kiếm");
    public static readonly LoaiDon DonMarketingMangVe = new LoaiDon(nameof(DonMarketingMangVe), "Đơn marketing mang về");
    public static readonly LoaiDon DonMarketingHoTro = new LoaiDon(nameof(DonMarketingHoTro), "Đơn marketing hỗ trợ");
    public static readonly LoaiDon DonDuAn = new LoaiDon(nameof(DonDuAn), "Đơn dự án");
    public static readonly LoaiDon DonSolutionPhanMem = new LoaiDon(nameof(DonSolutionPhanMem), "Đơn Solution (Phần mềm)");
    public static readonly LoaiDon DonTongDaiDienThoiai = new LoaiDon(nameof(DonTongDaiDienThoiai), "Đơn tổng đài/điện thoại");
    public static readonly LoaiDon DonSaleHangChuyenVe = new LoaiDon(nameof(DonSaleHangChuyenVe), "Đơn sales hãng chuyển về");
    public static readonly LoaiDon DonWebPage = new LoaiDon(nameof(DonWebPage), "Đơn web/page");
    public static readonly LoaiDon DonFaceBook = new LoaiDon(nameof(DonFaceBook), "Đơn Facebook");
    public static readonly LoaiDon DonZalo = new LoaiDon(nameof(DonZalo), "Đơn zalo");





    private LoaiDon(string name, string value) : base(name, value) { }
}
