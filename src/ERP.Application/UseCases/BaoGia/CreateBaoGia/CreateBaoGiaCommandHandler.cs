using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Domain.Entities.Sales.BaoGias.BaoGiaChiTiet;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Enumerations;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.BaoGia.CreateBaoGia;
public class CreateBaoGiaCommandHandler : ICommandHandler<CreateBaoGiaCommand>
{
    private readonly IBaoGiaRepository _baoGiaRepository;

    public CreateBaoGiaCommandHandler(IBaoGiaRepository baoGiaRepository)
    {
        _baoGiaRepository = baoGiaRepository;
    }

    public async Task<Result> Handle(CreateBaoGiaCommand request, CancellationToken cancellationToken)
    {
        DateTime ngayBaoGia = request.NgayBaoGia.ConvertToDate();
        DateOnly? ngayDuyetCMDuoi20 = request.NgayDuyetCMDuoi20.ConvertToDateOnly();
        string soBaoGia = await _baoGiaRepository.GenerateCode(x => x.SoBaoGia, Prefix.BG);
        DuyetCMDuoi20 duyetCMDuoi20 = DuyetCMDuoi20.Create(request.CanDuyetCMDuoi20, request.NguoiDuyetCMDuoi20, ngayDuyetCMDuoi20, request.GhiChuDuyetCMDuoi20);
        var addBaoGia = ERP.Domain.Entities.Sales.BaoGias.BaoGia.BaoGia.Create(
            soBaoGia,
            ngayBaoGia,
            request.IdKhachHang,
            request.IdLienHe,
            request.HieuLucBaoGia,
            request.IdDieuKhoanThanhToan,
            request.IdDieuKhoanThanhToanKhachHang,
            request.ThanhTienNet,
            request.ThanhTien0,
            request.ThanhTien8,
            request.ThanhTien10,
            request.TongThanhTien,
            request.TienThuDichVuVat,
            LoaiDon.FromValue(request.LoaiDon),
            TrangThaiDon.FromValue(request.TrangThaiDon),
            request.LyDoTruot,
            request.NgayTruot.ConvertToDateOnly(),
            TrangThaiDuyet.FromValue(request.TrangThaiDuyet),
            request.LyDoHuyDuyet,
            KhaNangTrung.FromValue(request.KhaNangTrung),
            request.IsBaoGiaQuanTrong,
            request.SR, request.SR2,
            request.SA,
            request.IdCTKM,
            request.ChiNhanh,
            request.KhoXuLy,
            request.DiaChiGiaoHang,
            request.NguoiNhanHang,
            request.NgayDuKienGiao.ConvertToDateOnly(),
            request.SoLuongComment,
            duyetCMDuoi20,
            request.IASHoTro1,
            request.IASHoTro2
            );
        await _baoGiaRepository.Add(addBaoGia);
        List<BaoGiaChiTiet> baoGiaChiTiets = new List<BaoGiaChiTiet>();
        foreach (var item in request.AddBaoGiaChiTiets)
        {
            DateTime? ngayNhatHang = item.ThoiGianGiaoHang.ConvertToDate();
            var donGia = DonGia.Create(item.DonGiaNet, item.DonGiaBan, item.DonGiaMoi, item.DonGiaDichVuVat);
            var giaBanThucTe = GiaBanThucTe.Create(item.GiaBanThucTe1, item.GiaBanThucTe2, item.GiaBanThucTe3, item.GiaBanThucTe4);
            var baoGiaChiTiet = BaoGiaChiTiet.Create(
                addBaoGia.Id,
                idHangHoa: item.IdHangHoa,
                maDieuChinh: item.MaDieuChinh,
                tenHang: item.TenHang,
                idNhomHang: item.IdNhomHang,
                itemCode: item.ItemCode,
                soLuong: item.SoLuong,
                donViTinh: item.DonViTinh,
                baoHanh: item.BaoHanh,
                donGia: donGia,
                thanhTienNet: item.ThanhTienNet,
                thanhTienHang: item.ThanhTienHang,
                thueGTGT: item.ThueGTGT,
                thueDichVuVat: item.ThueDichVuVat,
                tongThanhTien: item.TongThanhTien,
                phanTramCM: item.PhanTramCM,
                thueTNDN: item.ThueTNDN,
                tienThueTNDN: item.TienThueTNDN,
                tienKhachNhan: item.TienKhachNhan,
                thoiGianGiaoHang: ngayNhatHang,
                idKhoXuLy: item.IdKhoXuLy,
                ghiChu: item.GhiChu,
                soLuongTon: item.SoLuongTon,
                hinhAnhMinhHoa: item.HinhAnhMinhHoa,
                discontinue: item.Discontinue,
                noiDungYeuCauHoiHang: item.NoiDungYeuCauHoiHang,
                maXinGia: item.MaXinGia,
                TrangThaiDuyetGia.FromValue(item.TrangThaiDuyetGia),
                giaBanThucTe: giaBanThucTe,
                giaGMinTinhThuong: item.GiaGMinTinhThuong,
                laMaKhuyenMai: item.LaMaKhuyenMai,
                laMaLo: item.LaMaLo);

            baoGiaChiTiets.Add(baoGiaChiTiet);
        }

        addBaoGia.AddBaoGiaChiTiet(baoGiaChiTiets);
        return Result.Success($"Tạo thành công phiếu: {addBaoGia.Id}");
    }
}
