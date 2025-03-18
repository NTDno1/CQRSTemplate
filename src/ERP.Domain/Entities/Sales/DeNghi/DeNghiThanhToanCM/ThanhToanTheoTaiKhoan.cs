using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.DeNghiThanhToan.DeNghiThanhToanCM;

public class ThanhToanTheoTaiKhoan : SmartEnum<ThanhToanTheoTaiKhoan, string>
{
    public static readonly ThanhToanTheoTaiKhoan HOPLONG = new ThanhToanTheoTaiKhoan(nameof(HOPLONG), "HOPLONG");
    public static readonly ThanhToanTheoTaiKhoan TAHCM = new ThanhToanTheoTaiKhoan(nameof(TAHCM), "TAHCM");


    private ThanhToanTheoTaiKhoan(string name, string value) : base(name, value) { }
}
