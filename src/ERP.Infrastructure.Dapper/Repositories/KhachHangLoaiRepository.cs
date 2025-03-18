using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Persistence;
using ERP.Persistence.Repositories;

namespace ERP.Infrastructure.Dapper.Repositories;
public class KhachHangLoaiRepository : RepositoryBase<KhachHangLoai, Ulid>, IKhachHangLoaiRepository
{
    public KhachHangLoaiRepository(ApplicationDbContext context)
        : base(context)
    {
    }
}
