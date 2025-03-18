using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.KhachHang;

public sealed class KhachHangNganhNghe : AggregateRoot
{

    private KhachHangNganhNghe()
    {

    }

    public string NganhNghe { get; private set; }

    public Ulid IdLoaiKhach { get; private set; }

}
