using ERP.Domain.Abstractions.Repositories;
using ERP.Share.Responses.BaoGiaRespone;
namespace ERP.Domain.Entities.Sales.BaoGias.BaoGia;
public interface IBaoGiaRepository : IRepositoryBase<BaoGia, Ulid>
{
    Task<IEnumerable<BaoGiaRespone>> ListBaoGia(
        DateTime? tuNgay,
        DateTime? denNgay,
        string? soBaoGia,
        string? tenKhachHang,
        string? tenSaleBaoGia,
        string? congTy,
        string? tenMarkPhuTrach,
        int? soTrang,
        int? kichThuocTrang);

    Task<int> CountListBaoGia(
        DateTime? tuNgay,
        DateTime? denNgay,
        string? soBaoGia,
        string? tenKhachHang,
        string? tenSaleBaoGia,
        string? congTy,
        string? tenMarkPhuTrach);

    Task<IEnumerable<BaoGiaChiTietResopne>> DetailBaoGiaChiTiet(string idBaoGia);

    Task<BaoGiaRespone> DetailBaoGia(string idBaoGia);
}
