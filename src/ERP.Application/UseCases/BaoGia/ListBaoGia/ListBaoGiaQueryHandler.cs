using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;
using ERP.Share.Responses.BaoGiaRespone;

namespace ERP.Application.UseCases.BaoGia.ListBaoGia;
public class ListBaoGiaQueryHandler : IQueryHandler<ListBaoGiaQuery>
{
    private readonly IBaoGiaRepository _baoGiaRepository;

    public ListBaoGiaQueryHandler(IBaoGiaRepository baoGiaRepository)
    {
        _baoGiaRepository = baoGiaRepository;
    }

    public async Task<Result> Handle(ListBaoGiaQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        IEnumerable<BaoGiaRespone> listWhChuyenKho = await _baoGiaRepository.ListBaoGia(
            tuNgay,
            denNgay,
            request.soBaoGia,
            request.tenKhachHang,
            request.tenSaleBaoGia,
            request.congTy,
            request.tenMarkPhuTrach,
            request.soTrang > 0 ? request.soTrang : 1,
            request.kichThuocTrang > 0 ? request.kichThuocTrang : 10);

        int countListWhChuyenKho = await _baoGiaRepository.CountListBaoGia(
            tuNgay,
            denNgay,
            request.soBaoGia,
            request.tenKhachHang,
            request.tenSaleBaoGia,
            request.congTy,
            request.tenMarkPhuTrach);
        var pagedResult = new PagedResult
        {
            Items = listWhChuyenKho,
            Total = countListWhChuyenKho,
            PageNumber = request.soTrang ?? 1,
        };
        return Result.Success(pagedResult);
    }
}
