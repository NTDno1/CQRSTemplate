using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.System.ChiNhanh;

public sealed class ChiNhanh : AggregateRoot
{
    private ChiNhanh()
    {

    }

    private ChiNhanh(string maChiNhanh, string tenChiNhanh, int thuTuBaoCao)
    {
        Id = Ulid.NewUlid();
        MaChiNhanh = maChiNhanh;
        TenChiNhanh = tenChiNhanh;
        ThuTuBaoCao = thuTuBaoCao;
    }
    public string MaChiNhanh { get; private set; }
    public string TenChiNhanh { get; private set; }
    public int ThuTuBaoCao { get; private set; }

}
