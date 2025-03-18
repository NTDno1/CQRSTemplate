using ERP.Domain.Entities.Sales.BaoGias.BaoGia;
using ERP.Domain.Entities.Sales.BaoGias.BaoGiaChiTiet;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.BaoGia.UpdateBaoGia;
internal class UpdateBaoGiaCommandHandler : ICommandHandler<UpdateBaoGiaCommand>
{
    private readonly IBaoGiaRepository _baoGiaRepository;

    public UpdateBaoGiaCommandHandler(IBaoGiaRepository baoGiaRepository)
    {
        _baoGiaRepository = baoGiaRepository;
    }

    public async Task<Result> Handle(UpdateBaoGiaCommand request, CancellationToken cancellationToken)
    {
        ERP.Domain.Entities.Sales.BaoGias.BaoGia.BaoGia baoGia = await _baoGiaRepository.FindByIdAsync(request.IdBaoGia, cancellationToken, u => u.BaoGiaChiTiets);
        if (baoGia == null)
        {
            return Result.Failure<string>(new Error("NotFound", $"Không tìm thấy phiếu báo giá {request.IdBaoGia}!"));
        }

        var baoGiaChiTiets = new List<BaoGiaChiTiet>();
        var baoGiaChiTietBanDau = baoGia.BaoGiaChiTiets.ToList();

        if (request.UpdateBaoGiaChiTiets != null)
        {
            foreach (Share.DTO.UpdateBaoGiaChiTietDTO items in request.UpdateBaoGiaChiTiets)
            {
                BaoGiaChiTiet? getBaoGiaChiTietBanDau = baoGiaChiTietBanDau.Find(x => x.Id == items.Id);
                var giaBanThucTe = GiaBanThucTe.Create(items.GiaBanThucTe1, items.GiaBanThucTe2, items.GiaBanThucTe3, items.GiaBanThucTe4);
                DateTime thoiGianGiaoHang = items.ThoiGianGiaoHang.ConvertToDate();

                if (getBaoGiaChiTietBanDau != null)
                {
                    decimal donGiaNet = items.DonGiaNet ?? getBaoGiaChiTietBanDau.DonGia.DonGiaNet;
                    decimal donGiaBan = items.DonGiaBan ?? getBaoGiaChiTietBanDau.DonGia.DonGiaBan;
                    decimal donGiaMoi = items.DonGiaMoi ?? getBaoGiaChiTietBanDau.DonGia.DonGiaMoi;
                    decimal donGiaDichVuVat = items.DonGiaDichVuVat ?? getBaoGiaChiTietBanDau.DonGia.DonGiaDichVuVat;
                    var donGia = DonGia.Create(donGiaNet, donGiaBan, donGiaMoi, donGiaDichVuVat);
                    var trangThaiDuyetGia = TrangThaiDuyetGia.FromValue(items.TrangThaiDuyetGia);
                    getBaoGiaChiTietBanDau.Update(
                        items.MaDieuChinh,
                        items.TenHang,
                        items.IdNhomHang,
                        items.ItemCode,
                        items.SoLuong,
                        items.DonViTinh,
                        items.BaoHanh,
                        donGia,
                        items.ThanhTienNet,
                        items.ThanhTienHang,
                        items.ThueGTGT,
                        items.ThueDichVuVat,
                        items.TongThanhTien,
                        items.PhanTramCM,
                        items.ThueTNDN,
                        items.TienThueTNDN,
                        items.TienKhachNhan,
                        thoiGianGiaoHang,
                        items.IdKhoXuLy,
                        items.GhiChu,
                        items.SoLuongTon,
                        items.HinhAnhMinhHoa,
                        items.Discontinue,
                        items.NoiDungYeuCauHoiHang,
                        items.MaXinGia,
                        trangThaiDuyetGia,
                        giaBanThucTe,
                        items.GiaGMinTinhThuong,
                        items.LaMaKhuyenMai,
                        items.LaMaLo);
                    baoGiaChiTiets.Add(getBaoGiaChiTietBanDau);
                }
                else
                {
                    decimal donGiaNet = items.DonGiaNet ?? 0;
                    decimal donGiaBan = items.DonGiaBan ?? 0;
                    decimal donGiaMoi = items.DonGiaMoi ?? 0;
                    decimal donGiaDichVuVat = items.DonGiaDichVuVat ?? 0;
                    var donGia = DonGia.Create(donGiaNet, donGiaBan, donGiaMoi, donGiaDichVuVat);
                    BaoGiaChiTiet whChuyenKhoChiTiet = BaoGiaChiTiet.Create(
                        idBaoGia: baoGia.Id,
                        idHangHoa: (Ulid)items.IdHangHoa,
                        maDieuChinh: items.MaDieuChinh,
                        tenHang: items.TenHang,
                        idNhomHang: items.IdNhomHang,
                        itemCode: items.ItemCode,
                        soLuong: items.SoLuong ?? 0,
                        donViTinh: items.DonViTinh,
                        baoHanh: items.BaoHanh ?? 0,
                        donGia: donGia,
                        thanhTienNet: items.ThanhTienNet,
                        thanhTienHang: items.ThanhTienHang,
                        thueGTGT: items.ThueGTGT,
                        thueDichVuVat: items.ThueDichVuVat,
                        tongThanhTien: items.TongThanhTien,
                        phanTramCM: items.PhanTramCM,
                        thueTNDN: items.ThueTNDN,
                        tienThueTNDN: items.TienThueTNDN,
                        tienKhachNhan: items.TienKhachNhan,
                        thoiGianGiaoHang: thoiGianGiaoHang,
                        idKhoXuLy: items.IdKhoXuLy,
                        ghiChu: items.GhiChu,
                        soLuongTon: items.SoLuongTon,
                        hinhAnhMinhHoa: items.HinhAnhMinhHoa,
                        discontinue: items.Discontinue ?? false,
                        noiDungYeuCauHoiHang: items.NoiDungYeuCauHoiHang,
                        maXinGia: items.MaXinGia,
                        TrangThaiDuyetGia.FromValue(items.TrangThaiDuyetGia),
                        giaBanThucTe: giaBanThucTe,
                        giaGMinTinhThuong: items.GiaGMinTinhThuong,
                        laMaKhuyenMai: items.LaMaKhuyenMai ?? false,
                        laMaLo: items.LaMaLo ?? false);
                    baoGiaChiTiets.Add(whChuyenKhoChiTiet);
                }
            }
        }

        //await baoGia.UpdateBaoGiaChiTiet(baoGiaChiTiets);

        //var duyetCMDuoi20 = DuyetCMDuoi20.Create();

        DateOnly? ngayDuKienGiao = request.NgayDuKienGiao?.ConvertToDateOnly();
        DateOnly? ngayTruot = request.NgayTruot?.ConvertToDateOnly();
        DateTime? ngayBaoGia = request.NgayBaoGia?.ConvertToDate();

        //baoGia.Update(
        //    ngayBaoGia,
        //    request.IdKhachHang,
        //    request.IdLienHe,
        //    request.HieuLucBaoGia,
        //    request.IdDieuKhoanThanhToan,
        //    request.IdDieuKhoanThanhToan,
        //    request.ThanhTienNet,
        //    request.ThanhTien0,
        //    request.ThanhTien8,
        //    request.ThanhTien10,
        //    request.TongThanhTien,
        //    request.TienThuDichVuVat,
        //    request.LoaiDon,
        //    request.TrangThaiDon,
        //    request.LyDoTruot,
        //    ngayTruot,
        //    request.TrangThaiDuyet,
        //    request.LyDoHuyDuyet,
        //    request.KhaNangTrung,
        //    request.IsBaoGiaQuanTrong,
        //    request.SR,
        //    request.SR2,
        //    request.SA,
        //    request.IdCTKM,
        //    request.ChiNhanh,
        //    request.KhoXuLy,
        //    request.DiaChiGiaoHang,
        //    request.NguoiNhanHang,
        //    ngayDuKienGiao,
        //    request.SoLuongComment,

        //    request.CanDuyetCMDuoi20 ?? baoGia.DuyetCMDuoi20.CanDuyetCMDuoi20,
        //    request.NguoiDuyetCMDuoi20,
        //    //request.NgayDuyetCMDuoi20.ConvertToDateOnly(),
        //    request.GhiChuDuyetCMDuoi20,

        //    request.IASHoTro1,
        //    request.IASHoTro2);
        return Result.Success($"Cập nhật thành công phiếu: {baoGia.Id}");
    }
}
