using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.System.LichSuDangNhap;


public sealed class LichSuDangNhap : AggregateRoot
{
    private LichSuDangNhap()
    {

    }

    public LichSuDangNhap(string idUser, DateTime thoiGianDangNhap, string linkTruyCap, string ipClient, string domainClient)
    {
        Id = Ulid.NewUlid();
        IdUser = idUser;
        ThoiGianDangNhap = thoiGianDangNhap;
        LinkTruyCap = linkTruyCap;
        IpClient = ipClient;
        DomainClient = domainClient;
    }

    public string IdUser { get; private set; }
    public DateTime ThoiGianDangNhap { get; private set; }
    public string LinkTruyCap { get; private set; }
    public string IpClient { get; private set; }
    public string DomainClient { get; private set; }

}
