using ERP.Domain.Abstractions.Repositories;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.KhachHangLienHe.ListKhachHangLienHe;
public class ListKhachHangLienHeQueryHandler : IQueryHandler<ListKhachHangLienHeQuery>
{
    private readonly IRepositoryBase<Domain.Entities.Sales.KhachHang.KhachHangLienHe, Ulid> _khachHangLienHeRepository;

    public ListKhachHangLienHeQueryHandler(IRepositoryBase<Domain.Entities.Sales.KhachHang.KhachHangLienHe, Ulid> khachHangLienHeRepository)
    {
        _khachHangLienHeRepository = khachHangLienHeRepository;
    }

    public Task<Result> Handle(ListKhachHangLienHeQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        List<Domain.Entities.Sales.KhachHang.KhachHangLienHe> khachHangLienHes = _khachHangLienHeRepository.FindAll().ToList();

        khachHangLienHes = khachHangLienHes
        .Where(d => tuNgay == null || d.NgayTao >= tuNgay)
        .Where(d => denNgay == null || d.NgayTao <= denNgay)
        .Where(d => request.tenLienHe == null || d.TenLienHe.Contains(request.tenLienHe))
        .Skip(((request.soTrang ?? 1) - 1) * (request.kichThuocTrang ?? 10))
        .Take(request.kichThuocTrang ?? 10).ToList();

        var pagedResult = new PagedResult
        {
            Items = khachHangLienHes,
            Total = khachHangLienHes.Count,
            PageNumber = request.soTrang ?? 1,
        };

        return Task.FromResult<Result>(Result.Success(pagedResult));
    }
}
