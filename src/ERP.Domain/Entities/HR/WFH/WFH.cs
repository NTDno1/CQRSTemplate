using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Shared;
using ERP.Domain.Entities.System.Users;

namespace ERP.Domain.Entities.HR.WFH;


public sealed class WFH : AggregateRoot, ISoftDelete
{

    private WFH()
    {

    }

    public string MaDeNghi { get; private set; }

    public string IdUser { get; private set; }
    public KhoangThoiGian KhoangThoiGian { get; private set; }
    public string LyDo { get; private set; }
    public string? IdUserDuyetDon { get; private set; }
    public DateTime? NgayDuyetDon { get; private set; }
    public string? NoiDungHuyDuyet { get; private set; }
    public TrangThaiDuyet? TrangThaiDuyet { get; private set; }
    public TrangThaiXuLy? TrangThaiXuLy { get; private set; }
    public TrangThaiTheoDoi? TrangThaiTheoDoi { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }
    public User User { get; private set; }

}
