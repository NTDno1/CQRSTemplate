using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.DeNghiThanhToan.DeNghiThanhToanCM;

public class HinhThucThanhToan : SmartEnum<HinhThucThanhToan, string>
{
    public static readonly HinhThucThanhToan TienMat = new HinhThucThanhToan(nameof(TienMat), "Tiền mặt");
    public static readonly HinhThucThanhToan ChuyenKhoan = new HinhThucThanhToan(nameof(ChuyenKhoan), "Chuyển khoản");
    public static readonly HinhThucThanhToan GiamTruCongNo = new HinhThucThanhToan(nameof(GiamTruCongNo), "Giảm trừ công nợ");

    private HinhThucThanhToan(string name, string value) : base(name, value) { }
}
