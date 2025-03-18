using System.Data;
using Dapper;
using ERP.Application.Abstractions.Authentication;
using ERP.Domain.Entities.WareHouses.NhapKho;
using ERP.Persistence;
using ERP.Persistence.Repositories;

namespace ERP.Infrastructure.Dapper.Repositories;
public class NhapKhoRepository : RepositoryBase<NhapKho, Ulid>, INhapKhoReposetory
{
    private readonly DapperContext _dapperContext;
    private readonly IUserContext _userContext;

    public NhapKhoRepository(ApplicationDbContext context, IUserContext userContext, DapperContext dapperContext) : base(context)
    {
        _dapperContext = dapperContext;
        _userContext = userContext;
    }


    public async Task<IEnumerable<dynamic>> GetDanhSachPhieuNhapKho(DateTime? Tungay, DateTime? Denngay, string? IdNhapKho, string? DoiTuong, string? NguoiTao, string? LoaiNhapKho, string? MaSoPo, string? ChiNhanh, int SoTrang, int SoBanGhi)
    {
        var parameters = new DynamicParameters();
        parameters.Add("TuNgay", Tungay);
        parameters.Add("DenNgay", Denngay);
        parameters.Add("IdNhapKho", IdNhapKho);
        parameters.Add("DoiTuong", DoiTuong);
        parameters.Add("NguoiTao", NguoiTao);
        parameters.Add("LoaiNhapKho", LoaiNhapKho);
        parameters.Add("MaSoPo", MaSoPo);
        parameters.Add("ChiNhanh", ChiNhanh);
        parameters.Add("UserId", _userContext.UserId);
        parameters.Add("SoTrang", SoTrang);
        parameters.Add("SoBanGhi", SoBanGhi);
        using IDbConnection db = _dapperContext.Connection;
        IEnumerable<dynamic> data = await db.QueryAsync<dynamic>("Proc_DanhSachNhapKho", parameters, commandType: CommandType.StoredProcedure);
        return data;
    }
}
