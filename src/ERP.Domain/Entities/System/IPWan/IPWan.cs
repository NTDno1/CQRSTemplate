using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.System.IPWan;

public sealed class IPWan : AggregateRoot
{
    private IPWan()
    {

    }

    private IPWan(string ip, string maVanPhong, string ghiChu)
    {
        Id = Ulid.NewUlid();
        Ip = ip;
        MaVanPhong = maVanPhong;
        GhiChu = ghiChu;
    }

    public string Ip { get; private set; }

    public string? MaVanPhong { get; private set; }

    public string? GhiChu { get; private set; }

}
