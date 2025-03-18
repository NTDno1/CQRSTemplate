using ERP.Domain.Abstractions.Repositories;
using ERP.Share.Responses.KhachHangRespone;

namespace ERP.Domain.Entities.Sales.KhachHangs;
public interface IKhachHangRepository : IRepositoryBase<KhachHang.KhachHang, Ulid>
{
    Task<int> CountListKhachHang(DateTime? tuNgay, DateTime? denNgay, string? maKhachHang);

    Task<IEnumerable<KhachHangRespone>> GetListKhachHang(
        DateTime? tuNgay,
        DateTime? denNgay,
        string? maKhachHang,
        string? soDienThoai,
        string? sr,
        string? sa,
        string? sr2,
        int? soTrang,
        int? kichThuocTrang);

    Task<DetailKhachHantgRespone> GetKhachHang(string idKhachHang);

    Task<KhachHangLienHeRespone> GetKhachHangLienHe(string idKhachHang);

    Task<TaiKhoanNganHangKhachHangRespone> GetTaiKhoanNganHangKhachHang(string idKhachHang);

    Task<IEnumerable<PhanHoiKhachHangRespone>> GetPhanHoiKhachHang(string idKhachHang);

    Task<IEnumerable<DanhGiaKhachHangRespone>> GetDanhGiaKhachHang(string idKhachHang);

    Task<IEnumerable<KhaiHaiQuanRespone>> GetKhaiHaiQuan(string idKhachHang);
}
