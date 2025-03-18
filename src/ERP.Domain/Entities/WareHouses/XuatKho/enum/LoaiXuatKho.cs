using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.WareHouses.XuatKho;

public class LoaiXuatKho : SmartEnum<LoaiXuatKho, string>
{
    public static readonly LoaiXuatKho XuatKhoBanHang = new LoaiXuatKho(nameof(XuatKhoBanHang), "Xuất kho bán hàng");
    public static readonly LoaiXuatKho XuatKhoBanLe = new LoaiXuatKho(nameof(XuatKhoBanLe), "Xuất kho bán lẻ");
    public static readonly LoaiXuatKho XuatKhoBanHangChiNhanh = new LoaiXuatKho(nameof(XuatKhoBanHangChiNhanh), "Xuất kho bán hàng chi nhánh");
    public static readonly LoaiXuatKho XuatKhoBaoHanh = new LoaiXuatKho(nameof(XuatKhoBaoHanh), "Xuất kho bảo hành");
    public static readonly LoaiXuatKho XuatKhoDoiHang = new LoaiXuatKho(nameof(XuatKhoDoiHang), "Xuất kho đổi hàng");
    public static readonly LoaiXuatKho XuatKhoKhac = new LoaiXuatKho(nameof(XuatKhoKhac), "Xuất kho khác");
    public static readonly LoaiXuatKho XuatKhoKiemKe = new LoaiXuatKho(nameof(XuatKhoKiemKe), "Xuất kho kiểm kê");
    public static readonly LoaiXuatKho XuatkhoTraLaiMuaHang = new LoaiXuatKho(nameof(XuatkhoTraLaiMuaHang), "Xuất kho trả lại mua hàng");
    public static readonly LoaiXuatKho XuatKhoNoiBo = new LoaiXuatKho(nameof(XuatKhoNoiBo), "Xuất kho nội bộ");
    public static readonly LoaiXuatKho XuatKhoLinhKien = new LoaiXuatKho(nameof(XuatKhoLinhKien), "Xuất kho linh kiện");

    private LoaiXuatKho(string name, string value) : base(name, value) { }
}
