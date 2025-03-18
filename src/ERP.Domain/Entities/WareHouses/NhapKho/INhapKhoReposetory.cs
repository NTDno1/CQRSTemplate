using ERP.Domain.Abstractions.Repositories;

namespace ERP.Domain.Entities.WareHouses.NhapKho;
public interface INhapKhoReposetory : IRepositoryBase<NhapKho, Ulid>
{
    public Task<IEnumerable<dynamic>> GetDanhSachPhieuNhapKho(DateTime? Tungay, DateTime? Denngay, string? IdNhapKho, string? DoiTuong, string? NguoiTao, string? LoaiNhapKho, string? MaSoPo, string? ChiNhanh, int SoTrang, int SoBanGhi);
}
