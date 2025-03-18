using ERP.Domain.Abstractions.Repositories;
using ERP.Share.Responses.DeNghiSuaGiaRespone;
using ERP.Share.Responses.DeNghiTraLaiRespone;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiSuaGia;
public interface IDeNghiSuaGiaRepository : IRepositoryBase<DeNghiSuaGia, Ulid>
{
    Task<IEnumerable<DeNghiSuaGiaRespone>> GetListDeNghiSuaGia(DateTime? tuNgay, DateTime? denNgay, string? maChuan, int? soTrang, int? kichThuocTrang);

    Task<int> CountListDeNghiSuaGia(DateTime? tuNgay, DateTime? denNgay, string? maChuan);

    Task<IEnumerable<DeNghiTraLaiChiTietRespone>> GetDeNghiTraLaiSuaGia(string idDeNghi);

    Task<DetailDeNghiTraLaiRespone> GetDeNghiSuaGia(string idDeNghi);
}
