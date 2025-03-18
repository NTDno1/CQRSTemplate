using System.Data;
using Dapper;
using ERP.Domain.Entities.Sales.DeNghi.DeNghiSuaGia;
using ERP.Persistence;
using ERP.Persistence.Repositories;
using ERP.Share.Responses.DeNghiSuaGiaRespone;
using ERP.Share.Responses.DeNghiTraLaiRespone;

namespace ERP.Infrastructure.Dapper.Repositories;
public class DeNghiSuaGiaRepository : RepositoryBase<DeNghiSuaGia, Ulid>, IDeNghiSuaGiaRepository
{
    private readonly DapperContext _dapperContext;

    public DeNghiSuaGiaRepository(ApplicationDbContext context, DapperContext dapperContext) : base(context)
    {
        _dapperContext = dapperContext;
    }

    public Task<DetailDeNghiTraLaiRespone> GetDeNghiSuaGia(string idDeNghi)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DeNghiTraLaiChiTietRespone>> GetDeNghiTraLaiSuaGia(string idDeNghi)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<DeNghiSuaGiaRespone>> GetListDeNghiSuaGia(DateTime? tuNgay, DateTime? denNgay, string? maChuan, int? soTrang, int? kichThuocTrang)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("maChuan", maChuan);
        parameters.Add("soTrang", soTrang);
        parameters.Add("kichThuocTrang", kichThuocTrang);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<DeNghiSuaGiaRespone> datas = await db.QueryAsync<DeNghiSuaGiaRespone>("Proc_ListDeNghiSuaGia", parameters, commandType: CommandType.StoredProcedure);
        return datas;
    }

    public async Task<int> CountListDeNghiSuaGia(DateTime? tuNgay, DateTime? denNgay, string? maChuan)
    {
        var parameters = new DynamicParameters();
        parameters.Add("tuNgay", tuNgay);
        parameters.Add("denNgay", denNgay);
        parameters.Add("maChuan", maChuan);
        using IDbConnection db = _dapperContext.Connection;
        int total = await db.QuerySingleAsync<int>("Proc_CountListDeNghiSuaGia", parameters, commandType: CommandType.StoredProcedure);
        return total;
    }
}
