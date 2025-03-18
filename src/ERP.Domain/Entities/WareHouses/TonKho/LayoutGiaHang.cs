using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.WareHouses.TonKho;
internal sealed class LayoutGiaHang : AggregateRoot
{
    public LayoutGiaHang(Ulid idHangHoa, Ulid idKho, string giaHang, decimal soLuong)
    {
        IdHangHoa = idHangHoa;
        IdKho = idKho;
        GiaHang = giaHang;
        SoLuong = soLuong;
    }
    public Ulid IdHangHoa { get; set; }

    public Ulid IdKho { get; set; }

    public string GiaHang { get; set; }

    public decimal SoLuong { get; set; }


}
