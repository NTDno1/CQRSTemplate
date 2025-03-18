using ERP.Domain.Abstractions.Repositories;
using ERP.Share.Responses.DeNghiThanhToanCM;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
public interface IDeNghiThanhToanCMRepository : IRepositoryBase<DeNghiThanhToanCM, Ulid>
{
    Task<IEnumerable<DeNghiThanhToanCMResponse>> ListDeNghiThanhToanCM(DateTime? tuNgay, DateTime? denNgay, int? soTrang, int? kichThuocTrang);

    Task<int> CountDeNghiThanhToanCM(DateTime? tuNgay, DateTime? denNgay);

}
