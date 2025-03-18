namespace ERP.Domain.Entities.Sales.BaoGias.BaoGiaChiTiet;

public sealed record DonGia
{

    public decimal DonGiaNet { get; init; }
    public decimal DonGiaBan { get; init; }
    public decimal DonGiaMoi { get; init; }
    public decimal DonGiaDichVuVat { get; init; }
    public static DonGia Create(decimal donGiaNet, decimal donGiaBan, decimal donGiaMoi, decimal donGiaDichVuVat)
    {

        return new DonGia
        {
            DonGiaNet = donGiaNet,
            DonGiaBan = donGiaBan,
            DonGiaMoi = donGiaMoi,
            DonGiaDichVuVat = donGiaDichVuVat
        };
    }

}
