using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.WareHouses.XuatKho;
public sealed class XuatKhoSerial : AggregateRoot
{
    public XuatKhoSerial() { }
    public Ulid IdXuatKhoChiTiet { get; private set; }
    public string Serial { get; private set; }
    public bool DaTraLai { get; private set; }
    public XuatKhoChiTiet XuatKhoChiTiet { get; private set; }

}
