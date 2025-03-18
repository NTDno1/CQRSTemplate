using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.LoaiKhachHang.ListLoaiKhachHang;
public class ListKhachHangLoaiQueryHandler : IQueryHandler<ListKhachHangLoaiQuery>
{
    private readonly IKhachHangLoaiRepository _khachHangLoaiRepository;

    public ListKhachHangLoaiQueryHandler(IKhachHangLoaiRepository khachHangLoaiRepository)
    {
        _khachHangLoaiRepository = khachHangLoaiRepository;
    }

    public Task<Result> Handle(ListKhachHangLoaiQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        List<Domain.Entities.Sales.KhachHang.KhachHangLoai> khachHangLoais = _khachHangLoaiRepository.FindAll().ToList();

        khachHangLoais = khachHangLoais
       .Where(d => tuNgay == null || d.NgayTao >= tuNgay)
       .Where(d => denNgay == null || d.NgayTao <= denNgay)
       .Where(d => request.tenLoaiKhach == null || d.TenLoaiKhach.Contains(request.tenLoaiKhach))
       .Skip(((request.soTrang ?? 1) - 1) * (request.kichThuocTrang ?? 10))
       .Take(request.kichThuocTrang ?? 10).ToList();

        var pagedResult = new PagedResult
        {
            Items = khachHangLoais,
            Total = khachHangLoais.Count,
            PageNumber = request.soTrang ?? 1,
        };

        return Task.FromResult<Result>(Result.Success(pagedResult));
    }
}
