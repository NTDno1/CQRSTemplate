using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;
using ERP.Share.Responses.KhachHangRespone;

namespace ERP.Application.UseCases.KhachHang.ListKhachHang;
public class ListKhachHangQueryHandler : IQueryHandler<ListKhachHangQuery>
{
    private readonly IKhachHangRepository _khachHangRepository;

    public ListKhachHangQueryHandler(IKhachHangRepository khachHangRepository)
    {
        _khachHangRepository = khachHangRepository;
    }

    public async Task<Result> Handle(ListKhachHangQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = !string.IsNullOrEmpty(request.tuNgay) ? request.tuNgay.ConvertToDate() : null;
        DateTime? denNgay = !string.IsNullOrEmpty(request.denNgay) ? request.denNgay.ConvertToDate() : null;

        IEnumerable<KhachHangRespone> listKhachHang = await _khachHangRepository.GetListKhachHang(
            tuNgay,
            denNgay,
            request.maKhachHang,
            request.soDienThoai,
            request.sr,
            request.sa,
            request.sr2,
            request.soTrang > 0 ? request.soTrang : 1,
            request.kichThuocTrang > 0 ? request.kichThuocTrang : 10);

        int countListKhachHang = await _khachHangRepository.CountListKhachHang(tuNgay, denNgay, request.maKhachHang);

        var pagedResult = new PagedResult
        {
            Items = listKhachHang,
            Total = countListKhachHang,
            PageNumber = request.soTrang ?? 1,
        };
        return Result.Success(pagedResult);
    }
}
