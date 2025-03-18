using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.PURC;
public sealed class HinhAnhHangHoa : AggregateRoot
{
    private HinhAnhHangHoa()
    {

    }

    public HinhAnhHangHoa(Ulid idHangHoa, string linkAnh)
    {
        IdHangHoa = idHangHoa;
        LinkAnh = linkAnh;
    }

    public Ulid IdHangHoa { get; private set; }
    public string LinkAnh { get; private set; }

    public HangHoa.HangHoa? HangHoa { get; private set; }

    public static HinhAnhHangHoa Create(Ulid idHangHoa, string linkAnh)
    {
        return new HinhAnhHangHoa(idHangHoa, linkAnh);
    }


}
