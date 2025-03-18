using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Entities.Shared;

namespace ERP.Domain.Entities.Sales.DuyetXuatTruocHan;
public sealed class DuyetXuatTruocHan : AggregateRoot
{
    private DuyetXuatTruocHan()
    {

    }

    public string NguoiDeNghi { get; private set; }
    public DateTime NgayDeNghi { get; private set; }
    public Ulid IdXuatKho { get; private set; }
    public DateOnly NgayTinhCongNoGoc { get; private set; }
    public DateOnly NgayTinhCongNoMoi { get; private set; }
    public string LyDo { get; private set; }
    public DuyetDon DuyetDon { get; private set; }

}
