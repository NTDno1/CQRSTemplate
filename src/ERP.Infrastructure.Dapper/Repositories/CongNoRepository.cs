using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Persistence.Repositories;
using ERP.Persistence;
using ERP.Share.Responses.BaoGiaRespone;
using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Share.Responses.CongNoResponse;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;

namespace ERP.Infrastructure.Dapper.Repositories;
public class CongNoRepository : RepositoryBase<CongNoSR, Ulid>, ICongNoRepository
{
    private readonly DapperContext _dapperContext;
    public CongNoRepository(ApplicationDbContext context, DapperContext dapperContext) : base(context)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<CongNoResponse>> ListCongNo(DateTime? tuNgay, DateTime? denNgay, int? soTrang, int? kichThuocTrang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("soTrang", soTrang);
        parameters.Add("kichThuocTrang", kichThuocTrang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<CongNoResponse> total = await db.QueryAsync<CongNoResponse>("Proc_ListCongNoSR", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public async Task<int> CountListCongNo(DateTime? tuNgay, DateTime? denNgay)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        using IDbConnection db = _dapperContext.Connection;
        int total = await db.QuerySingleAsync<int>("Proc_CountListCongNoSR", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public Task<CongNoSR> FindByIdAsync(string id, CancellationToken cancellationToken = default, params Expression<Func<CongNoSR, object>>[] includeProperties)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CongNoCommentResponse>> ListCongNoComment(Ulid IdCongNo)
    {
        var parameters = new DynamicParameters();
        parameters.Add("IdCongNo", IdCongNo.ToString());
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<CongNoCommentResponse> total = await db.QueryAsync<CongNoCommentResponse>("Proc_ListCommentCongNoSR", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public async Task<IEnumerable<CongNoThucTeResponse>> ListCongNoThucTe(DateTime? tuNgay, DateTime? denNgay, int? soTrang, int? kichThuocTrang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("soTrang", soTrang);
        parameters.Add("kichThuocTrang", kichThuocTrang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<CongNoThucTeResponse> total = await db.QueryAsync<CongNoThucTeResponse>("Proc_ListCongNoSRThucTe", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public async Task<int> CountListCongNoThucTe(DateTime? tuNgay, DateTime? denNgay)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        using IDbConnection db = _dapperContext.Connection;
        int total = await db.QuerySingleAsync<int>("Proc_CountListCongNoSRThucTe", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }
}

