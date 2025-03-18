using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Persistence.Configurations.SALE.KhachHang;

public sealed class KhachHangEmailNhanHoaDon : AggregateRoot
{
    private KhachHangEmailNhanHoaDon()
    {

    }

    public Ulid IdHangHoa { get; private set; }

    public string EmailNhanHoaDon { get; private set; }

}
