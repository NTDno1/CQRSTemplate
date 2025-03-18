using Ardalis.SmartEnum;

namespace ERP.Domain.Entities.Sales.DeNghiThanhToan.DeNghiThanhToanCM;




public class TrangThaiDuyetDNTT : SmartEnum<TrangThaiDuyetDNTT, string>
{
    public static readonly TrangThaiDuyetDNTT ChoDuyet = new TrangThaiDuyetDNTT(nameof(ChoDuyet), "Chờ duyệt");
    public static readonly TrangThaiDuyetDNTT DaDuyet = new TrangThaiDuyetDNTT(nameof(DaDuyet), "Đã duyệt");
    public static readonly TrangThaiDuyetDNTT HuyDuyet = new TrangThaiDuyetDNTT(nameof(HuyDuyet), "Hủy duyệt");

    private TrangThaiDuyetDNTT(string name, string value) : base(name, value) { }
}
