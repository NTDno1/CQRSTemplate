using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.KhachHang;


public class TinhTrangHoatDong : SmartEnum<TinhTrangHoatDong, string>
{
    public static readonly TinhTrangHoatDong DangHoatDong = new TinhTrangHoatDong(nameof(DangHoatDong), "Đang hoạt động");
    public static readonly TinhTrangHoatDong DaNgungHoatDong = new TinhTrangHoatDong(nameof(DaNgungHoatDong), "Đã ngừng hoạt động");
    public static readonly TinhTrangHoatDong BlackList = new TinhTrangHoatDong(nameof(BlackList), "BlackList");

    private TinhTrangHoatDong(string name, string value) : base(name, value) { }
}

public class TinhTrangKhachHangLienHe : SmartEnum<TinhTrangKhachHangLienHe, string>
{
    public static readonly TinhTrangKhachHangLienHe ConLamViec = new TinhTrangKhachHangLienHe(nameof(ConLamViec), "Còn làm việc");
    public static readonly TinhTrangKhachHangLienHe DaNghiViec = new TinhTrangKhachHangLienHe(nameof(DaNghiViec), "Đã nghỉ việc");

    private TinhTrangKhachHangLienHe(string name, string value) : base(name, value) { }
}

