using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.HR.CongTacPhiPhuongTien;

public sealed class CongTacPhiPhuongTien : AggregateRoot
{

    private CongTacPhiPhuongTien()
    {

    }


    public Ulid IdDeNghiCongTacPhi { get; private set; }
    public decimal PhiPhuongTien { get; private set; }
    public float SoKilomet { get; private set; }
    public PhuongTien PhuongTien { get; private set; }
    public string? GhiChuPhuongTien { get; private set; }

}
