using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Domain.Entities.Sales.CongNoSR;
using ERP.Domain.Entities.Sales.DeNghi.DeNghiSuaGia;
using ERP.Domain.Entities.Sales.DeNghi.DeNghiThanhToanCM;
using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Domain.Entities.System.DieuKhoanThanhToan;
using ERP.Domain.Entities.System.Users;
using ERP.Domain.Entities.WareHouses.ChuyenKho;
using ERP.Domain.Entities.WareHouses.NhapKho;
using ERP.Infrastructure.Dapper.Repositories;
using ERP.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.Infrastructure.Dapper.DependencyInjection.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureDapper(this IServiceCollection services)
    {
        AddDapper(services);

        AddRepository(services);

        return services;
    }

    public static void AddRepository(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IChuyenKhoRepository, ChuyenKhoRepository>();
        services.AddTransient<IBaoGiaRepository, BaoGiaRepository>();
        services.AddTransient<IKhachHangRepository, KhachHangRepository>();
        services.AddTransient<IHangHoaRepository, HangHoaRepository>();
        services.AddTransient<INhapKhoReposetory, NhapKhoRepository>();
        services.AddTransient<IDieuKhoanThanhToanRepository, DieuKhoanThanhToanRepository>();
        services.AddTransient<IKhachHangLoaiRepository, KhachHangLoaiRepository>();
        services.AddTransient<IDeNghiTraLaiRepository, DeNghiTraLaiRepository>();
        services.AddTransient<ICongNoRepository, CongNoRepository>();
        services.AddTransient<IDeNghiThanhToanCMRepository, DeNghiThanhToanCMRepository>();
        services.AddTransient<IDeNghiSuaGiaRepository, DeNghiSuaGiaRepository>();
    }

    public static void AddDapper(IServiceCollection services)
    {
        services.AddSingleton<DapperContext>();
    }
}
