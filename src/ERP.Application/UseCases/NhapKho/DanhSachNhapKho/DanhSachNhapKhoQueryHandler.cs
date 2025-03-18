using ERP.Domain.Entities.WareHouses.NhapKho;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.NhapKho.DanhSachNhapKho;
public sealed class DanhSachNhapKhoQueryHandler : IQueryHandler<DanhSachNhapKhoQuery>
{
    private readonly INhapKhoReposetory _nhapKhoReposetory;

    public DanhSachNhapKhoQueryHandler(INhapKhoReposetory nhapKhoReposetory)
    {
        _nhapKhoReposetory = nhapKhoReposetory;
    }

    public async Task<Result> Handle(DanhSachNhapKhoQuery request, CancellationToken cancellationToken)
    {
        DateTime? tuNgay = request.Tungay?.ConvertToDate();
        DateTime? denNgay = request.Denngay?.ConvertToDate();
        int sotrang = request.SoTrang ?? 1;
        int soBanGhi = request.SoBanGhi ?? 10;

        IEnumerable<dynamic> listWhChuyenKho = await _nhapKhoReposetory.GetDanhSachPhieuNhapKho(
            tuNgay,
            denNgay,
            request.IdNhapKho ?? string.Empty,
            request.DoiTuong ?? string.Empty,
            request.NguoiTao ?? string.Empty,
            request.LoaiNhapKho ?? "Tất cả",
            request.MaSoPo ?? string.Empty,
            request.ChiNhanh ?? "Tất cả",
            sotrang,
            soBanGhi);
        //int countListWhChuyenKho = await _nhapKhoReposetory.CountListWhChuyenKho(tuNgay, denNgay, request.Id);
        var pagedResult = new PagedResult
        {
            Items = listWhChuyenKho,
            Total = 0,
            PageNumber = sotrang,
        };
        return Result.Success(pagedResult);


    }

}
