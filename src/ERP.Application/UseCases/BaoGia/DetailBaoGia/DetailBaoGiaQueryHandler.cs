using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Responses.BaoGiaRespone;

namespace ERP.Application.UseCases.BaoGia.DetailBaoGia;
public class DetailBaoGiaQueryHandler : IQueryHandler<DetailBaoGiaQuery>
{
    private readonly IBaoGiaRepository _baoGiaRepository;

    public DetailBaoGiaQueryHandler(IBaoGiaRepository baoGiaRepository)
    {
        _baoGiaRepository = baoGiaRepository;
    }

    public async Task<Result> Handle(DetailBaoGiaQuery request, CancellationToken cancellationToken)
    {
        BaoGiaRespone baoGiaResopne = await _baoGiaRepository.DetailBaoGia(request.idBaoGia);
        if (baoGiaResopne != null)
        {
            IEnumerable<BaoGiaChiTietResopne> chuyenKhoChiTietRespones = await _baoGiaRepository.DetailBaoGiaChiTiet(baoGiaResopne.Id.ToString());
            DetailBaoGiaRespone whChuyenKhoDetailDTO = new DetailBaoGiaRespone
            {
                Id = baoGiaResopne.Id,
                SoBaoGia = baoGiaResopne.SoBaoGia,
                NgayBaoGia = baoGiaResopne.NgayBaoGia,
                IdKhachHang = baoGiaResopne.IdKhachHang,
                IdLienHe = baoGiaResopne.IdLienHe,
                HieuLucBaoGia = baoGiaResopne.HieuLucBaoGia,
                IdDieuKhoanThanhToan = baoGiaResopne.IdDieuKhoanThanhToan,
                IdDieuKhoanThanhToanKhachHang = baoGiaResopne.IdDieuKhoanThanhToanKhachHang,
                ThanhTienNet = baoGiaResopne.ThanhTienNet,
                ThanhTienHang0 = baoGiaResopne.ThanhTienHang0,
                TienThueGTGT0 = baoGiaResopne.TienThueGTGT0,
                ThanhTienHang8 = baoGiaResopne.ThanhTienHang8,
                TienThueGTGT8 = baoGiaResopne.TienThueGTGT8,
                ThanhTienHang10 = baoGiaResopne.ThanhTienHang10,
                TienThueGTGT10 = baoGiaResopne.TienThueGTGT10,
                TongThanhTien = baoGiaResopne.TongThanhTien,
                TienThuDichVuVat = baoGiaResopne.TienThuDichVuVat,
                LoaiDon = baoGiaResopne.LoaiDon,
                TrangThaiDon = baoGiaResopne.TrangThaiDon,
                LyDoTruot = baoGiaResopne.LyDoTruot,
                NgayTruot = baoGiaResopne.NgayTruot,
                TrangThaiDuyet = baoGiaResopne.TrangThaiDuyet,
                LyDoHuyDuyet = baoGiaResopne.LyDoHuyDuyet,
                KhaNangTrung = baoGiaResopne.KhaNangTrung,
                IsBaoGiaQuanTrong = baoGiaResopne.IsBaoGiaQuanTrong,
                SR = baoGiaResopne.SR,
                SR2 = baoGiaResopne.SR2,
                SA = baoGiaResopne.SA,
                IdCTKM = baoGiaResopne.IdCTKM,
                ChiNhanh = baoGiaResopne.ChiNhanh,
                KhoXuLy = baoGiaResopne.KhoXuLy,
                DiaChiGiaoHang = baoGiaResopne.DiaChiGiaoHang,
                NguoiNhanHang = baoGiaResopne.NguoiNhanHang,
                NgayDuKienGiao = baoGiaResopne.NgayDuKienGiao,
                SoLuongComment = baoGiaResopne.SoLuongComment,
                CanDuyetCMDuoi20 = baoGiaResopne.CanDuyetCMDuoi20,
                NguoiDuyetCMDuoi20 = baoGiaResopne.NguoiDuyetCMDuoi20,
                NgayDuyetCMDuoi20 = baoGiaResopne.NgayDuyetCMDuoi20,
                GhiChuDuyetCMDuoi20 = baoGiaResopne.GhiChuDuyetCMDuoi20,
                IASHoTro1 = baoGiaResopne.IASHoTro1,
                IASHoTro2 = baoGiaResopne.IASHoTro2,
                IsDeleted = baoGiaResopne.IsDeleted,
                NgayXoa = baoGiaResopne.NgayXoa,
                NgayTao = baoGiaResopne.NgayTao,
                NgaySua = baoGiaResopne.NgaySua,
                NguoiTao = baoGiaResopne.NguoiTao,
                NguoiSua = baoGiaResopne.NguoiSua,
                TenKhachHang = baoGiaResopne.TenKhachHang,
                TenKhLienHe = baoGiaResopne.TenKhLienHe,
                DieuKhoanThanhToan = baoGiaResopne.DieuKhoanThanhToan,
                TenNguoiNhanHang = baoGiaResopne.TenNguoiNhanHang,
                TenNguoiDuyetCMDuoi20 = baoGiaResopne.TenNguoiDuyetCMDuoi20,
                BaoGiaChiTietResopnes = chuyenKhoChiTietRespones.ToList(),
            };
            return Result.Success(whChuyenKhoDetailDTO);
        }

        Error err = new Error("NotFound", $"Không tìm thấy số chứng từ!");
        return Result.Failure(err);
    }
}
