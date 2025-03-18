using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.WareHouses.NhapKho;
public class TrangThaiHoaDon : SmartEnum<TrangThaiHoaDon, string>
{
    public static readonly TrangThaiHoaDon HoaDonChamThuHoi = new TrangThaiHoaDon(nameof(HoaDonChamThuHoi), "Hóa đơn chậm thu hồi");
    public static readonly TrangThaiHoaDon HoaDonDauVaoSauNgayNhapKho = new TrangThaiHoaDon(nameof(HoaDonDauVaoSauNgayNhapKho), "Hóa đơn đầu vào sau ngày nhập kho");
    private TrangThaiHoaDon(string name, string value) : base(name, value) { }
}
