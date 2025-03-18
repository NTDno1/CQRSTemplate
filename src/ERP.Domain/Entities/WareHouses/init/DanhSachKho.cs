using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.WareHouses.init;
public sealed class DanhSachKho : AggregateRoot
{
    public DanhSachKho() { }
    public string TenKho { get; set; }
    public string? TrucThuocKho { get; set; }
    public string? GhiChu { get; set; }
    public string? DiaChi { get; set; }
    public bool SetBaoCao { get; set; }
    public string QrId { get; set; }
}
