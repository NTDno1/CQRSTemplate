using Dapper;
using System.Data;
using ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
using ERP.Persistence;
using ERP.Persistence.Repositories;
using ERP.Share.Responses.CongNoResponse;
using ERP.Share.Responses.DeNghiThanhToanCM;

namespace ERP.Infrastructure.Dapper.Repositories;
public class DeNghiThanhToanCMRepository : RepositoryBase<DeNghiThanhToanCM, Ulid>, IDeNghiThanhToanCMRepository
{
    private readonly DapperContext _dapperContext;

    public DeNghiThanhToanCMRepository(ApplicationDbContext context, DapperContext dapperContext) : base(context)
    {
        _dapperContext = dapperContext;
    }

    public async Task<int> CountDeNghiThanhToanCM(DateTime? tuNgay, DateTime? denNgay)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        using IDbConnection db = _dapperContext.Connection;
        int total = await db.QuerySingleAsync<int>("Proc_CountListDeNghiThanhToanCM", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public async Task<IEnumerable<DeNghiThanhToanCMResponse>> ListDeNghiThanhToanCM(DateTime? tuNgay, DateTime? denNgay, int? soTrang, int? kichThuocTrang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("soTrang", soTrang);
        parameters.Add("kichThuocTrang", kichThuocTrang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<DeNghiThanhToanCMResponse> total = await db.QueryAsync<DeNghiThanhToanCMResponse>("Proc_ListDeNghiThanhToanCM", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }
}
