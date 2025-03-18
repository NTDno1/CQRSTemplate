using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Shared;

namespace ERP.Domain.Entities.Sales.CongNoSR;
public sealed class CongNoSRThucTe : AggregateRoot, ISoftDelete
{
    private CongNoSRThucTe()
    {
    }

    public Ulid IdKhachHang { get; private set; }
    public decimal TongNo { get; private set; }
    public decimal TongCo { get; private set; }
    public decimal NoQuaHan { get; private set; }
    public decimal NoNoiBoQuaHan { get; private set; }
    public decimal NoDenHan { get; private set; }
    public KhoangThoiGian KhoangThoiGian { get; private set; }
    public string KetQuaThuHoi { get; private set; }
    public string KetQuaThuHoiQuaHan { get; private set; }
    public string KetQuaThuHoiDenHan { get; private set; }
    public string KetQuaThuHoiNgoaiDuKien { get; private set; }
    public decimal TongThuHoi { get; private set; }
    public bool CongNoXau { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }
}
