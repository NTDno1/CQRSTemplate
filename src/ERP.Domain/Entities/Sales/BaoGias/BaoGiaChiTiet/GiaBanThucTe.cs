namespace ERP.Domain.Entities.Sales.BaoGias.BaoGiaChiTiet;


public sealed record GiaBanThucTe
{

    public decimal? GiaBanThucTe1 { get; init; }
    public decimal? GiaBanThucTe2 { get; init; }
    public decimal? GiaBanThucTe3 { get; init; }
    public decimal? GiaBanThucTe4 { get; init; }

    public static GiaBanThucTe Create(decimal? giaBanThucTe1, decimal? giaBanThucTe2, decimal? giaBanThucTe3, decimal? giaBanThucTe4)
    {

        return new GiaBanThucTe
        {
            GiaBanThucTe1 = giaBanThucTe1,
            GiaBanThucTe2 = giaBanThucTe2,
            GiaBanThucTe3 = giaBanThucTe3,
            GiaBanThucTe4 = giaBanThucTe4
        };
    }

}
