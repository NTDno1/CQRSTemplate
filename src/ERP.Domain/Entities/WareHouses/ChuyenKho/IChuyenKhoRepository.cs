using ERP.Domain.Abstractions.Repositories;
using ERP.Share.Responses.ChuyenKho;

namespace ERP.Domain.Entities.WareHouses.ChuyenKho;
public interface IChuyenKhoRepository : IRepositoryBase<ChuyenKho, Ulid>
{
    Task<IEnumerable<ChuyenKhoRespone>> GetListWhChuyenKho(DateTime? tuNgay, DateTime? denNgay, string? maChuyenKho, int? soTrang, int? kichThuocTrang);

    Task<int> CountListWhChuyenKho(DateTime? tuNgay, DateTime? denNgay, string? maChuyenKho);

    Task<IEnumerable<ChuyenKhoChiTietRespone>> GetDetailWhChuyenKhoChiTiet(string SoChungTu);

    Task<ChuyenKhoRespone> GetDetailWhChuyenKho(string SoChungTu);
}
