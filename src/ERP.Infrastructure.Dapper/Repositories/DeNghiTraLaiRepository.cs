using System.Data;
using Dapper;
using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Persistence;
using ERP.Persistence.Repositories;
using ERP.Share.Responses.DeNghiTraLaiRespone;

namespace ERP.Infrastructure.Dapper.Repositories;
public class DeNghiTraLaiRepository : RepositoryBase<DeNghiTraLai, Ulid>, IDeNghiTraLaiRepository
{
    private readonly DapperContext _dapperContext;

    public DeNghiTraLaiRepository(ApplicationDbContext context, DapperContext dapperContext)
        : base(context)
    {
        _dapperContext = dapperContext;
    }

    public async Task<IEnumerable<DeNghiTraLaiRespone>> GetListDeNghiTraLai(DateTime? tuNgay, DateTime? denNgay, string? maDeNghi, int? soTrang, int? kichThuocTrang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("maDeNghi", maDeNghi);
        parameters.Add("soTrang", soTrang);
        parameters.Add("kichThuocTrang", kichThuocTrang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<DeNghiTraLaiRespone> datas = await db.QueryAsync<DeNghiTraLaiRespone>("Proc_ListDeNghiTraLai", parameters, commandType: CommandType.StoredProcedure);
        return datas;
    }

    public async Task<int> CountListDeNghiTraLai(DateTime? tuNgay, DateTime? denNgay, string maDeNghi)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("maDeNghi", maDeNghi);
        using IDbConnection db = _dapperContext.Connection;
        int total = await db.QuerySingleAsync<int>("Proc_CountListDeNghiTraLai", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }

    public async Task<IEnumerable<DeNghiTraLaiChiTietRespone>> GetDeNghiTraLaiChiTiet(string idDeNghi)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idDeNghi", idDeNghi);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<DeNghiTraLaiChiTietRespone> value = await db.QueryAsync<DeNghiTraLaiChiTietRespone>("Proc_DeNghiTraLaiChiTiet", parameters, commandType: CommandType.StoredProcedure);
        return value;
    }

    public async Task<DetailDeNghiTraLaiRespone> GetDeNghiTraLai(string idDeNghi)
    {
        var parameters = new DynamicParameters();
        parameters.Add("idDeNghi", idDeNghi);
        using IDbConnection db = _dapperContext.Connection;
        DetailDeNghiTraLaiRespone? value = await db.QuerySingleAsync<DetailDeNghiTraLaiRespone>("Proc_DeNghiTraLai", parameters, commandType: CommandType.StoredProcedure);
        return value;
    }

}
