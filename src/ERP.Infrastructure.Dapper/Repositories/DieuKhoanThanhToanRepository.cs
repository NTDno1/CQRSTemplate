using ERP.Domain.Entities.System.DieuKhoanThanhToan;
using ERP.Persistence;
using ERP.Persistence.Repositories;

namespace ERP.Infrastructure.Dapper.Repositories;
public class DieuKhoanThanhToanRepository : RepositoryBase<DieuKhoanThanhToan, Ulid>, IDieuKhoanThanhToanRepository
{
    private readonly DapperContext _dapperContext;

    public DieuKhoanThanhToanRepository(ApplicationDbContext context, DapperContext dapperContext) : base(context)
    {
        _dapperContext = dapperContext;
    }
}
