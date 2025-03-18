namespace ERP.Domain.Entities.Sales.KhachHang;

public sealed record ThongTinLienHe
{

    public string TenCongTy { get; init; }
    public string DiaChiVanPhong { get; init; }
    public string DiaChiXuatHoaDon { get; init; }
    public string EmailNhanHoaDon { get; init; }
    public string SoDienThoai { get; init; }
    public string MaSoThue { get; init; }
    public string Website { get; init; }
    public static ThongTinLienHe Create(string tenCongTy, string diaChiVanPhong, string diaChiXuatHoaDon, string emailNhanHoaDoan, string soDienThoai, string maSoThue, string website)
    {
        return new ThongTinLienHe
        {
            TenCongTy = tenCongTy,
            DiaChiVanPhong = diaChiVanPhong,
            DiaChiXuatHoaDon = diaChiXuatHoaDon,
            EmailNhanHoaDon = emailNhanHoaDoan,
            SoDienThoai = soDienThoai,
            MaSoThue = maSoThue,
            Website = website
        };
    }
}
