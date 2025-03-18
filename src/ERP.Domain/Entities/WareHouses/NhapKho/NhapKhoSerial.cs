using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.WareHouses.NhapKho;
public sealed class NhapKhoSerial : AggregateRoot
{
    public NhapKhoSerial() { }
    public Ulid IdNhapKhoChiTiet { get; private set; }
    public string Serial { get; private set; }
    public bool DaTraLaiNcc { get; private set; }
    public NhapKhoChiTiet NhapKhoChiTiet { get; private set; }
}
