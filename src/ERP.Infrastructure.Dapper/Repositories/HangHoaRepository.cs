using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Persistence;
using ERP.Persistence.Repositories;

namespace ERP.Infrastructure.Dapper.Repositories;
public class HangHoaRepository : RepositoryBase<HangHoa, Ulid>, IHangHoaRepository
{
    public HangHoaRepository(ApplicationDbContext context) : base(context)
    {
    }
}
