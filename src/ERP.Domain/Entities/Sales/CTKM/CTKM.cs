using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Shared;

namespace ERP.Domain.Entities.Sales.CTKM;
public sealed class CTKM : AggregateRoot, ISoftDelete
{

    private readonly List<CTKMChaoKhachHang> _CTKMChaoKhachHangs;

    private CTKM()
    {
        _CTKMChaoKhachHangs = [];
    }


    public string TenCTKM { get; private set; }
    public KhoangThoiGian KhoangThoiGian { get; set; }
    public string CodeCTKM { get; private set; }
    public string Detail { get; private set; }
    public string PhanLoai { get; private set; }
    public string NoiDungTruyenThong { get; private set; }
    //public TrangThaiCTKM TrangThaiCTKM { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }



    public IReadOnlyCollection<CTKMChaoKhachHang> CTKMChaoKhachHangs => _CTKMChaoKhachHangs.AsReadOnly();

}
