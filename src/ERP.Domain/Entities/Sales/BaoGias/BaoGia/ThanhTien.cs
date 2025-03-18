namespace ERP.Domain.Entities.Sales.BaoGias.BaoGia;

public sealed record ThanhTien
{

    public decimal ThanhTienHang { get; init; }
    public decimal TienThueGTGT { get; init; }

    public static ThanhTien Create(decimal thanhTienHang, decimal tienThueGTGT)
    {

        return new ThanhTien
        {
            ThanhTienHang = thanhTienHang,
            TienThueGTGT = tienThueGTGT
        };
    }

}
