using ERP.Domain.Abstractions.Repositories;
using ERP.Share.Responses.DeNghiTraLaiRespone;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
public interface IDeNghiTraLaiRepository : IRepositoryBase<DeNghiTraLai, Ulid>
{
    Task<IEnumerable<DeNghiTraLaiRespone>> GetListDeNghiTraLai(DateTime? tuNgay, DateTime? denNgay, string? maDeNghi, int? soTrang, int? kichThuocTrang);

    Task<int> CountListDeNghiTraLai(DateTime? tuNgay, DateTime? denNgay, string? maDeNghi);

    Task<IEnumerable<DeNghiTraLaiChiTietRespone>> GetDeNghiTraLaiChiTiet(string idDeNghi);

    Task<DetailDeNghiTraLaiRespone> GetDeNghiTraLai(string idDeNghi);

}
