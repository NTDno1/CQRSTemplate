using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.Sales.CTKM;
public sealed class CTKMChaoKhachHang : AggregateRoot, ISoftDelete
{
    private CTKMChaoKhachHang()
    {

    }

    public Ulid IdCTKM { get; private set; }
    public Ulid IdKhachHang { get; private set; }
    public bool IsThamGia { get; private set; }
    public bool IsQuanTam { get; private set; }
    public decimal TargetChao { get; private set; }
    public decimal TargetChot { get; private set; }
    public bool IsKhachHangDongYMua { get; private set; }
    public string SaleThemKhach { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public CTKM CTKM { get; private set; }

}
