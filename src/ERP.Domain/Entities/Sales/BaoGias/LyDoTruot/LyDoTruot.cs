using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.BaoGias.LyDoTruot;

public sealed class LyDoTruot : AggregateRoot
{

    private LyDoTruot()
    {

    }

    public Ulid IdBaoGia { get; private set; }
    public Ulid IdHangHoa { get; private set; }
    public decimal GiaHienTai { get; private set; }
    public decimal GiaTarget { get; private set; }
    public LyDoTruotDon LyDo { get; private set; }
    public string? LyDoChiTiet { get; private set; }
    public string? TenDoiThu { get; private set; }

    public BaoGia.BaoGia BaoGia { get; set; }
}
