using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.Sales.BaoGias;


public sealed class BaoGiaComment : AggregateRoot, ISoftDelete
{

    private BaoGiaComment()
    {

    }

    public Ulid IdBaoGia { get; private set; }
    public string NoiDungComment { get; private set; }
    public bool? IsGiaTri { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public BaoGia.BaoGia BaoGia { get; set; }
}
