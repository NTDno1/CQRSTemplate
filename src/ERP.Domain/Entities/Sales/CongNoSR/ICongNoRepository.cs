using ERP.Domain.Abstractions.Repositories;
using ERP.Share.Responses.CongNoResponse;

namespace ERP.Domain.Entities.Sales.CongNoSR;
public interface ICongNoRepository : IRepositoryBase<CongNoSR, Ulid>
{
    Task<IEnumerable<CongNoResponse>> ListCongNo(DateTime? tuNgay, DateTime? denNgay, int? soTrang, int? kichThuocTrang);

    Task<int> CountListCongNo(DateTime? tuNgay, DateTime? denNgay);

    Task<IEnumerable<CongNoCommentResponse>> ListCongNoComment(Ulid IdCongNo);

    Task<IEnumerable<CongNoThucTeResponse>> ListCongNoThucTe(DateTime? tuNgay, DateTime? denNgay, int? soTrang, int? kichThuocTrang);

    Task<int> CountListCongNoThucTe(DateTime? tuNgay, DateTime? denNgay);
}
