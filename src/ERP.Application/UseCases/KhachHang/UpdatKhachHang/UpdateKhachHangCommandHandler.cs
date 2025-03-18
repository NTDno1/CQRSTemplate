using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Domain.Entities.Sales.KhachHang.DanhGiaKhachHang;
using ERP.Domain.Entities.Sales.KhachHang.PhanHoiKhachHang;
using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.KhachHang.UpdatKhachHang;
public class UpdateKhachHangCommandHandler : ICommandHandler<UpdateKhachHangCommand>
{
    private readonly IKhachHangRepository _khachHangRepository;


    public UpdateKhachHangCommandHandler(IKhachHangRepository khachHangRepository)
    {
        _khachHangRepository = khachHangRepository;
    }

    public async Task<Result> Handle(UpdateKhachHangCommand request, CancellationToken cancellationToken)
    {
        ERP.Domain.Entities.Sales.KhachHang.KhachHang khachHang = await _khachHangRepository.FindByIdAsync(
            request.id,
            cancellationToken,
            u => u.KhachHangLienHes,
            u => u.TaiKhoanNganHangKhachHangs,
            u => u.PhanHoiKhachHangs,
            u => u.DanhGiaKhachHangs,
            u => u.KhaiHaiQuans);
        if (khachHang == null)
        {
            return Result.Failure<string>(new Error("NotFound", "Không tìm thấy phiếu nhập kho!"));
        }

        khachHang.Update(
            request.TenCongTy,
            request.DiaChiVanPhong,
            request.DiaChiXuatHoaDon,
            request.EmailNhanHoaDon,
            request.SoDienThoai,
            request.MaSoThue,
            request.Website,
            soNhaDuongPhoGiaoHang: request.SoNhaDuongPhoGiaoHang,
            quanHuyenGiaoHang: request.QuanHuyenGiaoHang,
            tinhThanhPhoGiaoHang: request.TinhThanhPhoGiaoHang,
            request.HoaDonMacDinh,
            ghiChuHoaDonMacDinh: request.GhiChuHoaDonMacDinh,
            idLoaiKhach: request.IdLoaiKhach,
            nganhNghe: request.NganhNghe,
            khuCongNghiep: request.KhuCongNghiep,
            nguonGocKhachHang: request.NguonGocKhachHang,
            sR: request.SR,
            sR_DangKy: request.SR_DangKy,
            sR2: request.SR2,
            sR2_DangKy: request.SR2_DangKy,
            sA: request.SA,
            sA_DangKy: request.SA_DangKy,
            quanLy: request.QuanLy,
            bU: request.BU,
            ghiChuKhachHang: request.GhiChuKhachHang,
            hoSoThanhToan: request.HoSoThanhToan,
            idDieuKhoanThanhToan: request.IdDieuKhoanThanhToan,
            idDieuKhoanThanhToanNoiBo: request.IdDieuKhoanThanhToanNoiBo,
            tinhTrangHoatDong: request.TinhTrangHoatDong,
            nguoiDaiDien: request.NguoiDaiDien,
            chucVuNguoiDaiDien: request.ChucVuNguoiDaiDien,
            cMNDNguoiDaiDien: request.CMNDNguoiDaiDien,
            canHDNT: request.CanHDNT,
            daCoHDNT: request.DaCoHDNT,
            kyPO: request.KyPO,
            danhGiaKhachHang: request.DanhGiaKhachHang,
            ngungCapHang: request.NgungCapHang,
            ghiChuCongNo: request.GhiChuCongNo,
            dongDau: request.DongDau,
            inTheoMauMacDinh: request.InTheoMauMacDinh,
            khoMacDinh: request.KhoMacDinh,
            temMacDinh: request.TemMacDinh,
            giayChungNhanDauTu: request.GiayChungNhanDauTu,
            canGiayChungNhanDauTu: request.CanGiayChungNhanDauTu,
            ngayCapGiayChungNhanDauTu: request.NgayCapGiayChungNhanDauTu,
            canYeuCauXacNhanCongNo: request.CanYeuCauXacNhanCongNo,
            hienGiaKhiInPhieuXuatKho: request.HienGiaKhiInPhieuXuatKho,
            dSE: request.DSE,
            vendorStatus: request.VendorStatus,
            heThongKhachHang: request.HeThongKhachHang,
            mangKinhDoanh: request.MangKinhDoanh);
        _khachHangRepository.Update(khachHang);

        if (request.KhachHangLienHe != null)
        {
            khachHang.UpdateKhachHangLienHe(
                request.KhachHangLienHe.Id,
                request.KhachHangLienHe.TenLienHe,
                request.KhachHangLienHe.VaiTro,
                request.KhachHangLienHe.SoDienThoai,
                request.KhachHangLienHe.Email,
                request.KhachHangLienHe.TinhTrang,
                request.KhachHangLienHe.GhiChu);
        }

        if (request.TaiKhoanNganHang != null)
        {
            khachHang.UpdateTaiKhoanNganHang(
                request.TaiKhoanNganHang.Id,
                request.TaiKhoanNganHang.SoTaiKhoan,
                request.TaiKhoanNganHang.LoaiTaiKhoan,
                request.TaiKhoanNganHang.TenTaiKhoan,
                request.TaiKhoanNganHang.NganHang,
                request.TaiKhoanNganHang.ChiNhanh,
                request.TaiKhoanNganHang.TinhThanhPho,
                request.TaiKhoanNganHang.HinhThucThanhToan);
        }

        if (request.PhanHoiKhachHangs != null)
        {
            List<PhanHoiKhachHang> phanHoiKhachHangs = new List<PhanHoiKhachHang>();
            List<PhanHoiKhachHang>? baoGiaChiTietBanDau = khachHang.PhanHoiKhachHangs.ToList();
            foreach (var items in request.PhanHoiKhachHangs)
            {
                PhanHoiKhachHang? phanHoiKhachHang = baoGiaChiTietBanDau.FirstOrDefault(x => x.Id == items.Id);

                if (phanHoiKhachHang != null)
                {
                    DateTime ngayPhanHoi = items.NgayPhanHoi.ConvertToDate();
                    phanHoiKhachHang.Update(
                        ngayPhanHoi,
                        items.IdUserPhanHoi,
                        items.NoiDungPhanHoi,
                        items.IdKhachHang,
                        items.LoaiPhanHoi,
                        items.CoGiaTri);
                    phanHoiKhachHangs.Add(phanHoiKhachHang);
                }
                else
                {
                    DateTime ngayPhanHoi = items.NgayPhanHoi.ConvertToDate();
                    PhanHoiKhachHang phanHoiKhachHangToAdd = PhanHoiKhachHang.Create(
                        ngayPhanHoi,
                        items.IdUserPhanHoi,
                        items.NoiDungPhanHoi,
                        items.IdKhachHang,
                        items.LoaiPhanHoi,
                        items.CoGiaTri);
                    phanHoiKhachHangs.Add(phanHoiKhachHangToAdd);
                }
            }

            khachHang.UpdatePhanHoiKhachHang(phanHoiKhachHangs);
        }

        if (request.DanhGiaKhachHangs != null)
        {
            List<DanhGiaKhachHang> danhGiaKhachHangs = new List<DanhGiaKhachHang>();
            List<DanhGiaKhachHang> getDanhGiaKhachHang = khachHang.DanhGiaKhachHangs.ToList();
            foreach (var items in request.DanhGiaKhachHangs)
            {
                DanhGiaKhachHang? danhGiaKhachHang = getDanhGiaKhachHang.FirstOrDefault(x => x.Id == items.Id);

                if (danhGiaKhachHang != null)
                {
                    danhGiaKhachHang.Update(
                        items.NganhNghe,
                        items.NamThanhLap,
                        items.SoLuongNhanVien,
                        items.NguoiQuyetDinhMuaHang,
                        items.SanPhamQuanTam,
                        items.HangQuanTam,
                        items.CoNhaXuong,
                        items.SanLuongSanXuat,
                        items.DoiThuCanhTranh,
                        items.CoHoiPhatTrien,
                        items.HopDongDaKy,
                        items.IdCTKMThamGia,
                        items.DuAnTiemNangSapToi,
                        items.TinhHinhTaiChinh,
                        items.LuuY);
                    danhGiaKhachHangs.Add(danhGiaKhachHang);
                }
                else
                {
                    var danhGiaKhachHangToAdd = DanhGiaKhachHang.Create(
                        items.NganhNghe,
                        items.NamThanhLap,
                        items.SoLuongNhanVien,
                        items.NguoiQuyetDinhMuaHang,
                        items.SanPhamQuanTam,
                        items.HangQuanTam,
                        items.CoNhaXuong,
                        items.SanLuongSanXuat,
                        items.DoiThuCanhTranh,
                        items.CoHoiPhatTrien,
                        items.HopDongDaKy,
                        items.IdCTKMThamGia,
                        items.DuAnTiemNangSapToi,
                        items.TinhHinhTaiChinh,
                        items.LuuY,
                        khachHang.Id);
                    danhGiaKhachHangs.Add(danhGiaKhachHangToAdd);
                }
            }

            khachHang.UpdateDanhGiaKhachHang(danhGiaKhachHangs);
        }

        if (request.KhaiHaiQuans != null)
        {
            List<KhaiHaiQuan> khaiHaiQuans = new List<KhaiHaiQuan>();
            List<KhaiHaiQuan> getKhaiHaiQuan = khachHang.KhaiHaiQuans.ToList();
            foreach (var items in request.KhaiHaiQuans)
            {
                KhaiHaiQuan? khaiHaiQuan = getKhaiHaiQuan.FirstOrDefault(x => x.Id == items.Id);

                if (khaiHaiQuan != null)
                {
                    khaiHaiQuan.Update(
                        items.ChiCucHaiQuan,
                        items.MaDiaDiemLuuKhoHangChoThongQuanDuKien,
                        items.DiaDiemDoHang,
                        items.DiaDiemDichChoVanChuyenBaoThue,
                        items.GhiChuLamHaiQuanMayDau,
                        items.GhiChuChungTuNhapKhachHangCanCheck,
                        items.ThongTinLienHeKhachHang,
                        items.BoChungTuBanCung,
                        items.TermOfSale,
                        items.TenTiengAnh);

                    khaiHaiQuans.Add(khaiHaiQuan);
                }
                else
                {
                    KhaiHaiQuan khaiHaiQuanToAdd = KhaiHaiQuan.Create(
                                   khachHang.Id,
                                   items.ChiCucHaiQuan,
                                   items.MaDiaDiemLuuKhoHangChoThongQuanDuKien,
                                   items.DiaDiemDoHang,
                                   items.DiaDiemDichChoVanChuyenBaoThue,
                                   items.GhiChuLamHaiQuanMayDau,
                                   items.GhiChuChungTuNhapKhachHangCanCheck,
                                   items.ThongTinLienHeKhachHang,
                                   items.BoChungTuBanCung,
                                   items.TermOfSale,
                                   items.TenTiengAnh);
                    khaiHaiQuans.Add(khaiHaiQuanToAdd);
                }
            }

            khachHang.UpdateKhaiHaiQuan(khaiHaiQuans);
        }

        return Result.Success($"Cập nhật thành công khách hàng: {khachHang.Id}");
    }
}
