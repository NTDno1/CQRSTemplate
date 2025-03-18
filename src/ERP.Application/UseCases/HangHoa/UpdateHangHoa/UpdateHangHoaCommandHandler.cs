using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.HangHoa.UpdateHangHoa;
public class UpdateHangHoaCommandHandler : ICommandHandler<UpdateHangHoaCommand>
{

    private readonly IHangHoaRepository _hangHoaRepository;

    public UpdateHangHoaCommandHandler(IHangHoaRepository hangHoaRepository)
    {
        _hangHoaRepository = hangHoaRepository;
    }

    public async Task<Result> Handle(UpdateHangHoaCommand request, CancellationToken cancellationToken)
    {
        var hhExist = await _hangHoaRepository.FindByIdAsync(request.IdHangHoa, cancellationToken, x => x.HinhAnhHangHoas);
        if (hhExist == null)
        {
            Error error = new Error("NotFound", $"Không tìm thấy mã hàng với ID {request.IdHangHoa}");
            return Result.Failure(error);
        }

        hhExist.Update(
            request.MaChuan,
            request.HsCode,
            request.ThongSoKyThuat,
            request.TenHang,
            request.IdNhomHang,
            request.DonViTinh,
            request.KhoiLuong,
            request.XuatXu,
            request.Vat,
            request.GiaNhap,
            request.GiaBan1,
            request.GiaBan2,
            request.GiaBan3,
            request.GiaBan4,
            request.GiaBan5,
            request.Ck1,
            request.Ck2,
            request.Ck3,
            request.Ck4,
            request.Ck5,
            request.MaChuyenDoi,
            request.GhiChu,
            request.LinkSanPham,
            request.PhuKienDiKem,
            request.SoNgayCapHang,
            request.IsTachMa,
            request.TinhTrangHangHoa,
            request.DongSanPham,
            request.MangKinhDoanh,
            request.GiaDaiLy,
            request.PhanLoaiHangHoa,
            request.TenHangBaoCao,
            request.HinhAnhs);

        return Result.Success();
    }
}
