using System.Data;
using Dapper;
using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Persistence;
using ERP.Persistence.Repositories;
using ERP.Share.Responses.ChuyenKho;

namespace ERP.Infrastructure.Dapper.Repositories;
public class ChuyenKhoRepository : RepositoryBase<ChuyenKho, Ulid>, IChuyenKhoRepository
{

    private readonly DapperContext _dapperContext;

    public ChuyenKhoRepository(ApplicationDbContext context, DapperContext dapperContext) : base(context)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<ChuyenKhoRespone>> GetListWhChuyenKho(DateTime? tuNgay, DateTime? denNgay, string? maChuyenKho, int? soTrang, int? kichThuocTrang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("maChuyenKho", maChuyenKho);
        parameters.Add("soTrang", soTrang);
        parameters.Add("kichThuocTrang", kichThuocTrang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<ChuyenKhoRespone> list = await db.QueryAsync<ChuyenKhoRespone>("Proc_ListChuyenKho", parameters, commandType: CommandType.StoredProcedure);
        return list;
    }

    public async Task<int> CountListWhChuyenKho(DateTime? tuNgay, DateTime? denNgay, string? maChuyenKho)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("maChuyenKho", maChuyenKho);
        using IDbConnection db = _dapperContext.Connection;
        int total = await db.QuerySingleAsync<int>("Proc_CountListChuyenKho", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public async Task<IEnumerable<ChuyenKhoChiTietRespone>> GetDetailWhChuyenKhoChiTiet(string SoChungTu)
    {
        var parameters = new DynamicParameters();
        parameters.Add("SoChungTu", SoChungTu);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<ChuyenKhoChiTietRespone> value = await db.QueryAsync<ChuyenKhoChiTietRespone>("Proc_ChuyenKhoChiTiet", parameters, commandType: CommandType.StoredProcedure);
        return value;
    }

    public async Task<ChuyenKhoRespone> GetDetailWhChuyenKho(string SoChungTu)
    {
        var parameters = new DynamicParameters();
        parameters.Add("SoChungTu", SoChungTu);
        using IDbConnection db = _dapperContext.Connection;
        ChuyenKhoRespone value = await db.QuerySingleAsync<ChuyenKhoRespone>("Proc_ChuyenKho",
            parameters,
            commandType: CommandType.StoredProcedure);
        return value;
    }
}
