using System.Data;
using Dapper;
using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Persistence;
using ERP.Persistence.Repositories;
using ERP.Share.Responses.BaoGiaRespone;

namespace ERP.Infrastructure.Dapper.Repositories;
public class BaoGiaRepository : RepositoryBase<BaoGia, Ulid>, IBaoGiaRepository
{
    private readonly DapperContext _dapperContext;

    public BaoGiaRepository(ApplicationDbContext context, DapperContext dapperContext)
        : base(context)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<BaoGiaRespone>> ListBaoGia(
        DateTime? tuNgay,
        DateTime? denNgay,
        string? soBaoGia,
        string? tenKhachHang,
        string? tenSaleBaoGia,
        string? congTy,
        string? tenMarkPhuTrach,
        int? soTrang,
        int? kichThuocTrang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("soBaoGia", soBaoGia);
        parameters.Add("tenKhachHang", tenKhachHang);
        parameters.Add("tenSaleBaoGia", tenSaleBaoGia);
        parameters.Add("congTy", congTy);
        parameters.Add("tenMarkPhuTrach", tenMarkPhuTrach);
        parameters.Add("soTrang", soTrang);
        parameters.Add("kichThuocTrang", kichThuocTrang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<BaoGiaRespone> datas = await db.QueryAsync<BaoGiaRespone>("Proc_ListBaoGia", parameters, commandType: CommandType.StoredProcedure);
        return datas;
    }

    public async Task<int> CountListBaoGia(
        DateTime? tuNgay,
        DateTime? denNgay,
        string? soBaoGia,
        string? tenKhachHang,
        string? tenSaleBaoGia,
        string? congTy,
        string? tenMarkPhuTrach)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("soBaoGia", soBaoGia);
        parameters.Add("tenKhachHang", tenKhachHang);
        parameters.Add("tenSaleBaoGia", tenSaleBaoGia);
        parameters.Add("congTy", congTy);
        parameters.Add("tenMarkPhuTrach", tenMarkPhuTrach);
        using IDbConnection db = _dapperContext.Connection;
        int total = await db.QuerySingleAsync<int>("Proc_CountListBaoGia", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public async Task<IEnumerable<BaoGiaChiTietResopne>> DetailBaoGiaChiTiet(string idBaoGia)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idBaoGia", idBaoGia);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<BaoGiaChiTietResopne> datas = await db.QueryAsync<BaoGiaChiTietResopne>("Proc_BaoGiaChiTiet", parameters, commandType: CommandType.StoredProcedure);
        return datas;
    }

    public async Task<BaoGiaRespone> DetailBaoGia(string idBaoGia)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idBaoGia", idBaoGia);
        using IDbConnection db = _dapperContext.Connection;
        BaoGiaRespone datas = await db.QuerySingleAsync<BaoGiaRespone>("Proc_BaoGia", parameters, commandType: CommandType.StoredProcedure);
        return datas;
    }
}
