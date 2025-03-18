using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.CongNoSR;
public sealed class CongNoSRComment : AggregateRoot
{
    private CongNoSRComment()
    {

    }

    public Ulid IdCongNo { get; private set; }
    public string SaleComment { get; private set; }
    public string AcctComment { get; private set; }
    public string NoiDungComment { get; private set; }

    public CongNoSR CongNoSR { get; private set; }

    public static CongNoSRComment Create(
        Ulid idCongNo, string saleComment, string acctComment, string noiDungComment
)
    {
        return new CongNoSRComment
        {
            Id = Ulid.NewUlid(),
            IdCongNo = idCongNo,
            SaleComment = saleComment,
            AcctComment = acctComment,
            NoiDungComment = noiDungComment,
        };
    }


}
