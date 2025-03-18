using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Enumerations;

namespace ERP.Application.UseCases.HangHoa.CreateHangHoa;
public sealed class CreateHangHoaCommandHandler : ICommandHandler<CreateHangHoaCommand>
{
    private readonly IHangHoaRepository _hangHoaRepository;

    public CreateHangHoaCommandHandler(IHangHoaRepository hangHoaRepository)
    {
        _hangHoaRepository = hangHoaRepository;
    }

    public async Task<Result> Handle(CreateHangHoaCommand request, CancellationToken cancellationToken)
    {
        string maHang = await _hangHoaRepository.GenerateCode(x => x.MaHang, Prefix.MH);
        var hangHoa = Domain.Entities.PURC.HangHoa.HangHoa.Create(maHang, request.MaChuan, request.HsCode, request.ThongSoKyThuat, request.TenHang, request.IdNhomHang, request.DonViTinh, request.KhoiLuong, request.XuatXu, request.Vat, request.GiaNhap, request.GiaBan1, request.GiaBan2, request.GiaBan3, request.GiaBan4, request.GiaBan5, request.Ck1, request.Ck2, request.Ck3, request.Ck4, request.Ck5, request.MaChuyenDoi, request.GhiChu, request.LinkSanPham, request.PhuKienDiKem, request.SoNgayCapHang, request.IsTachMa, request.TinhTrangHangHoa, request.DongSanPham, request.MangKinhDoanh, request.GiaDaiLy, request.PhanLoaiHangHoa, request.TenHangBaoCao, request.HinhAnhs);

        await _hangHoaRepository.Add(hangHoa);
        return Result.Success(maHang);
    }
}
