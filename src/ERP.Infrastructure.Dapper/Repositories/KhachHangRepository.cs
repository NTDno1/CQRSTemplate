using System.Data;
using Dapper;
using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Persistence;
using ERP.Persistence.Repositories;
using ERP.Share.Responses.KhachHangRespone;

namespace ERP.Infrastructure.Dapper.Repositories;
internal class KhachHangRepository : RepositoryBase<KhachHang, Ulid>, IKhachHangRepository
{
    private readonly DapperContext _dapperContext;

    public KhachHangRepository(ApplicationDbContext context, DapperContext dapperContext)
        : base(context)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<KhachHangRespone>> GetListKhachHang(
        DateTime? tuNgay,
        DateTime? denNgay,
        string? maKhachHang,
        string? soDienThoai,
        string? sr,
        string? sa,
        string? sr2,
        int? soTrang,
        int? kichThuocTrang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("maKhachHang", maKhachHang);
        parameters.Add("soDienThoai", soDienThoai);
        parameters.Add("sr", sr);
        parameters.Add("sa", sa);
        parameters.Add("sr2", sr2);
        parameters.Add("soTrang", soTrang);
        parameters.Add("kichThuocTrang", kichThuocTrang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<KhachHangRespone> total = await db.QueryAsync<KhachHangRespone>("Proc_ListKhachHang", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    async Task<int> IKhachHangRepository.CountListKhachHang(DateTime? tuNgay, DateTime? denNgay, string? maKhachHang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("maKhachHang", maKhachHang);
        using IDbConnection db = _dapperContext.Connection;
        int total = await db.QuerySingleAsync<int>("Proc_CountListKhachHang", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public async Task<DetailKhachHantgRespone> GetKhachHang(string idKhachHang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idKhachHang", idKhachHang);
        using IDbConnection db = _dapperContext.Connection;
        DetailKhachHantgRespone detail = await db.QueryFirstAsync<DetailKhachHantgRespone>("Proc_KhachHang", parameters, commandType: CommandType.StoredProcedure);
        return detail;
    }

    public async Task<KhachHangLienHeRespone> GetKhachHangLienHe(string idKhachHang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idKhachHang", idKhachHang);
        using IDbConnection db = _dapperContext.Connection;
        KhachHangLienHeRespone? detail = await db.QueryFirstAsync<KhachHangLienHeRespone?>("Proc_GetKhachHangLienHe", parameters, commandType: CommandType.StoredProcedure);
        return detail;
    }

    public async Task<TaiKhoanNganHangKhachHangRespone> GetTaiKhoanNganHangKhachHang(string idKhachHang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idKhachHang", idKhachHang);
        using IDbConnection db = _dapperContext.Connection;
        TaiKhoanNganHangKhachHangRespone? detail = await db.QueryFirstAsync<TaiKhoanNganHangKhachHangRespone?>("Proc_GetTaiKhoanNganHangKhachHang", parameters, commandType: CommandType.StoredProcedure);
        return detail;
    }

    public async Task<IEnumerable<PhanHoiKhachHangRespone>> GetPhanHoiKhachHang(string idKhachHang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idKhachHang", idKhachHang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<PhanHoiKhachHangRespone>? detail = await db.QueryAsync<PhanHoiKhachHangRespone>("Proc_GetPhanHoiKhachHang", parameters, commandType: CommandType.StoredProcedure);
        return detail;
    }

    public async Task<IEnumerable<DanhGiaKhachHangRespone>> GetDanhGiaKhachHang(string idKhachHang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idKhachHang", idKhachHang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<DanhGiaKhachHangRespone>? detail = await db.QueryAsync<DanhGiaKhachHangRespone>("Proc_GetDanhGiaKhachHang", parameters, commandType: CommandType.StoredProcedure);
        return detail;
    }

    public async Task<IEnumerable<KhaiHaiQuanRespone>> GetKhaiHaiQuan(string idKhachHang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idKhachHang", idKhachHang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<KhaiHaiQuanRespone> detail = await db.QueryAsync<KhaiHaiQuanRespone>("Proc_GetKhaiHaiQuan", parameters, commandType: CommandType.StoredProcedure);
        return detail;
    }
}
