using ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.DeNghiTraLai.UpdateDeNghiTraLai;
internal class UpdateDeNghiTraLaiCommandHandler : ICommandHandler<UpdateDeNghiTraLaiCommand>
{
    private readonly IDeNghiTraLaiRepository _deNghiTraLaiRepository;

    public UpdateDeNghiTraLaiCommandHandler(IDeNghiTraLaiRepository deNghiTraLaiRepository)
    {
        _deNghiTraLaiRepository = deNghiTraLaiRepository;
    }

    public async Task<Result> Handle(UpdateDeNghiTraLaiCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Sales.DeNghi.DeNghiTraLai.DeNghiTraLai deNghiTraLai = await _deNghiTraLaiRepository.FindByIdAsync(request.id, cancellationToken, x => x.DeNghiTraLaiChiTiets);
        if (deNghiTraLai == null)
        {
            return Result.Failure<string>(new Error("NotFound", "Không tìm thấy phiếu đề nghị trả lại!"));
        }

        DateTime? ngayLeaderDuyet = request.ngayLeaderDuyet?.ConvertToDate();
        DateTime? ngayKyThuatDuyet = request.ngayKyThuatDuyet?.ConvertToDate();

        deNghiTraLai.Update(
            request.nguoiDeNghi,
            request.maNhatHang,
            request.soPhieuNhapKho,
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
            request.soPhieuXuatKho,
            request.trucThuoc,
            request.idKhoNhapHang,
            request.hinhThucTraLai,
            request.soTienPhiNhapLai,
            request.lyDoThuPhiNhapLai);
        List<DeNghiTraLaiChiTiet> deNghiTraLaiChiTiets = new List<DeNghiTraLaiChiTiet>();
        List<DeNghiTraLaiChiTiet> deNghiTraLaiChiTietsBanDau = deNghiTraLai.DeNghiTraLaiChiTiets.ToList();

        if (request.deNghiTraLaiChiTiets != null)
        {
            foreach (var items in request.deNghiTraLaiChiTiets)
            {
                DeNghiTraLaiChiTiet? deNghiTraLaiChiTiet = deNghiTraLaiChiTietsBanDau.Find(x => x.Id == items.Id);

                if (deNghiTraLaiChiTiet != null)
                {
                    deNghiTraLaiChiTiet.Update(
                        items.IdHangHoa,
                        items.MaDieuChinh,
                        items.SoLuong,
                        items.DonGiaBan,
                        items.DonGiaVon,
                        items.GhiChu,
                        items.ThueGTGT,
                        items.IdChiTietXuatKho,
                        items.DaNhapKho,
                        items.SoLuongDaNhap);
                    deNghiTraLaiChiTiets.Add(deNghiTraLaiChiTiet);
                }
                else
                {
                    var deNghiTraLaiChiTiet1 = DeNghiTraLaiChiTiet.Create(
                        deNghiTraLai.Id,
                        items.IdHangHoa,
                        items.MaDieuChinh,
                        items.SoLuong,
                        items.DonGiaBan,
                        items.DonGiaVon,
                        items.GhiChu,
                        items.ThueGTGT,
                        items.IdChiTietXuatKho,
                        items.DaNhapKho,
                        items.SoLuongDaNhap);
                    deNghiTraLaiChiTiets.Add(deNghiTraLaiChiTiet1);
                }
            }
        }

        deNghiTraLai.UpdateDeNghiTraLaiChiTiet(deNghiTraLaiChiTiets);
        return Result.Success("Tạo thành công");
    }
}
