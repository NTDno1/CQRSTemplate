using ERP.Domain.Entities.System.DieuKhoanThanhToan;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.DieuKhoanThanhToan;
public class ListDieuKhoanThanhToanQueryHandler : IQueryHandler<ListDieuKhoanThanhToanQuery>
{
    private readonly IDieuKhoanThanhToanRepository _dieuKhoanThanhToanRepository;

    public ListDieuKhoanThanhToanQueryHandler(IDieuKhoanThanhToanRepository dieuKhoanThanhToanRepository)
    {
        _dieuKhoanThanhToanRepository = dieuKhoanThanhToanRepository;
    }

    public Task<Result> Handle(ListDieuKhoanThanhToanQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        List<Domain.Entities.System.DieuKhoanThanhToan.DieuKhoanThanhToan> dieuKhoanThanhToans = _dieuKhoanThanhToanRepository.FindAll().ToList();

        dieuKhoanThanhToans = dieuKhoanThanhToans
       .Where(d => tuNgay == null || d.NgayTao >= tuNgay)
       .Where(d => denNgay == null || d.NgayTao <= denNgay)
       .Where(d => request.thoiHanThanhToan == null || d.ThoiHanThanhToan.Contains(request.thoiHanThanhToan))
       .Skip(((request.soTrang ?? 1) - 1) * (request.kichThuocTrang ?? 10))
       .Take(request.kichThuocTrang ?? 10).ToList();

        var pagedResult = new PagedResult
        {
            Items = dieuKhoanThanhToans,
            Total = dieuKhoanThanhToans.Count,
            PageNumber = request.soTrang ?? 1,
        };

        return Task.FromResult<Result>(Result.Success(dieuKhoanThanhToans));
    }
}
