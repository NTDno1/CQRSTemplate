using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;

public sealed class DeNghiThanhToanCMChiTiet : AggregateRoot
{

    private DeNghiThanhToanCMChiTiet()
    {

    }

    public Ulid IdDeNghi { get; private set; }
    public Ulid IdXuatKho { get; private set; }
    public decimal ThanhTien { get; private set; }
    public string GhiChu { get; private set; }

    public DeNghiThanhToanCM DeNghiThanhToanCM { get; private set; }

}
