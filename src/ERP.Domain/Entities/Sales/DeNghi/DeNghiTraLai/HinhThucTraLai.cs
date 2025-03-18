using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;

public class HinhThucTraLai : SmartEnum<HinhThucTraLai, string>
{
    public static readonly HinhThucTraLai TraHangTrucTiepTaiKho = new HinhThucTraLai(nameof(TraHangTrucTiepTaiKho), "Khách hàng đã mua đem qua trả trực tiếp tại kho");
    public static readonly HinhThucTraLai KhachKhongMuaNua = new HinhThucTraLai(nameof(KhachKhongMuaNua), "Hàng chưa ra khỏi kho, khác hàng không mua nữa");
    public static readonly HinhThucTraLai HangDatShipChuaTraLaiKho = new HinhThucTraLai(nameof(HangDatShipChuaTraLaiKho), "Khách hàng đặt ship hàng trả lại qua kho");
    public static readonly HinhThucTraLai HangNhapChiNhanhChuyenRa = new HinhThucTraLai(nameof(HangNhapChiNhanhChuyenRa), "Hàng nhập lại chi nhánh chuyển ra");
    public static readonly HinhThucTraLai NhoGiaoVanChuyenVe = new HinhThucTraLai(nameof(NhoGiaoVanChuyenVe), "Khách hàng trả lại hàng nhờ giao vận chuyển về");
    public static readonly HinhThucTraLai ChuyenPhatNhanh = new HinhThucTraLai(nameof(ChuyenPhatNhanh), "Khách hàng chuyển phát nhanh hàng đến kho");
    public static readonly HinhThucTraLai Khac = new HinhThucTraLai(nameof(Khac), "Khác");



    private HinhThucTraLai(string name, string value) : base(name, value) { }
}
