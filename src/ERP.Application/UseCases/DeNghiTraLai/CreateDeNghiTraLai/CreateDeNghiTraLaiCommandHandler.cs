using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Enumerations;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.DeNghiTraLai.CreateDeNghiTraLai;
internal class CreateDeNghiTraLaiCommandHandler : ICommandHandler<CreateDeNghiTraLaiCommand>
{
    private readonly IDeNghiTraLaiRepository _deNghiTraLaiRepository;

    public CreateDeNghiTraLaiCommandHandler(IDeNghiTraLaiRepository deNghiTraLaiRepository)
    {
        _deNghiTraLaiRepository = deNghiTraLaiRepository;
    }

    public async Task<Result> Handle(CreateDeNghiTraLaiCommand request, CancellationToken cancellationToken)
    {
        DateOnly ngayDeNghi = request.ngayDeNghi.ConvertToDateOnly();

        DateTime? ngayLeaderDuyet = request.ngayLeaderDuyet?.ConvertToDate();
        DateTime? ngayKyThuatDuyet = request.ngayKyThuatDuyet?.ConvertToDate();
        string maDeNghi = await _deNghiTraLaiRepository.GenerateCode(x => x.MaDeNghi, Prefix.DNTL);
        var idDeNghiTraLai = Ulid.NewUlid();
        var deNghiTraLaiChiTiets = new List<DeNghiTraLaiChiTiet>();
        if (request.deNghiTraLaiChiTiets != null && request.deNghiTraLaiChiTiets.Count > 0)
        {
            foreach (var item in request.deNghiTraLaiChiTiets)
            {
                DeNghiTraLaiChiTiet deNghiTraLaiChiTiet = DeNghiTraLaiChiTiet.Create(
                    idDeNghiTraLai,
                    item.IdHangHoa,
                    item.MaDieuChinh,
                    item.SoLuong,
                    item.DonGiaBan,
                    item.DonGiaVon,
                    item.GhiChu,
                    item.ThueGTGT,
                    item.IdChiTietXuatKho,
                    item.DaNhapKho,
                    item.SoLuongDaNhap);
                deNghiTraLaiChiTiets.Add(deNghiTraLaiChiTiet);
            }
        }

        var deNghiTraLai = Domain.Entities.Sales.DeNghi.DeNghiTraLai.DeNghiTraLai.Create(
            idDeNghiTraLai,
            maDeNghi,
            ngayDeNghi,
            request.nguoiDeNghi,
            request.maNhatHang,
            request.soPhieuXuatKho,
            request.nguoiTraLai,
            request.lyDoDeNghi,
            request.leaderDuyet,
            ngayLeaderDuyet,
            request.trangThaiLeaderDuyet,
            request.ghiChuLeaderDuyet,
            request.kyThuatDuyet,
            ngayKyThuatDuyet,
            request.trangThaiKyThuatDuyet,
            request.ghiChuKyThuatDuyet,
            request.ghiChuDonHang,
            request.canDiLayHang,
            request.diaChiLayHang,
            request.nguoiGiaoHangThucTe,
            request.ghiChuGiaoNhan,
            request.daNhapKho,
            request.soPhieuNhapKho,
            request.trucThuoc,
            request.idKhoNhapHang,
            request.hinhThucTraLai,
            request.soTienPhiNhapLai,
            request.lyDoThuPhiNhapLai,
            deNghiTraLaiChiTiets);
        await _deNghiTraLaiRepository.Add(deNghiTraLai);
        return Result.Success(deNghiTraLai.Id);
    }
}
