using ERP.Domain.Entities.Sales.KhachHang;
using ERP.Domain.Entities.Sales.KhachHang.TaiKhoanNganHang;
using ERP.Domain.Entities.Sales.KhachHangs;
using ERP.Share.Abstractions.Shared;
using ERP.Share.Enumerations;
using ERP.Share.Extensions;

namespace ERP.Application.UseCases.KhachHang.CreateKhachHang;
public class CreateKhachHangCommandHandler : ICommandHandler<CreateKhachHangCommand>
{
    private readonly IKhachHangRepository _khachHangRepository;

    public CreateKhachHangCommandHandler(IKhachHangRepository khachHangRepository)
    {
        _khachHangRepository = khachHangRepository;
    }

    public async Task<Result> Handle(CreateKhachHangCommand request, CancellationToken cancellationToken)
    {
        DateOnly? ngayChungNhanDauTu = request.NgayCapGiayChungNhanDauTu.ConvertToDateOnly();
        Ulid idKhachHang = Ulid.NewUlid();

        string maKhachHang = await _khachHangRepository.GenerateCode(x => x.MaKhachHang, Prefix.KH);
        ThongTinLienHe thongTinLienHe = ThongTinLienHe.Create(request.TenCongTy, request.DiaChiVanPhong, request.DiaChiXuatHoaDon, request.EmailNhanHoaDon, request.SoDienThoai, request.MaSoThue, request.Website);
        TaiKhoanNganHangKhachHang taiKhoanNganHangKhachHang = TaiKhoanNganHangKhachHang.Create(
          request.TaiKhoanNganHang.SoTaiKhoan,
          idKhachHang,
          LoaiTaiKhoan.FromValue(request.TaiKhoanNganHang.LoaiTaiKhoan),
          request.TaiKhoanNganHang.TenTaiKhoan,
          request.TaiKhoanNganHang.NganHang,
          request.TaiKhoanNganHang.ChiNhanh,
          request.TaiKhoanNganHang.TinhThanhPho,
          HinhThucThanhToan.FromValue(request.TaiKhoanNganHang.HinhThucThanhToan));

        Domain.Entities.Sales.KhachHang.KhachHangLienHe addKhachHangLienHe = Domain.Entities.Sales.KhachHang.KhachHangLienHe.Create(
            request.KhachHangLienHe.TenLienHe,
            idKhachHang,
            request.KhachHangLienHe.VaiTro,
            request.KhachHangLienHe.SoDienThoai,
            request.KhachHangLienHe.Email,
            TinhTrangKhachHangLienHe.FromValue(request.KhachHangLienHe.TinhTrang),
            request.KhachHangLienHe.GhiChu);
        Domain.Entities.Sales.KhachHang.KhachHang addKhachHang = Domain.Entities.Sales.KhachHang.KhachHang.Create(
         idKhachHang,
         maKhachHang,
         request.IdKhachHangCha,
         thongTinLienHe,
         request.SoNhaDuongPhoGiaoHang,
         request.QuanHuyenGiaoHang,
         request.TinhThanhPhoGiaoHang,
         HoaDon.FromValue(request.HoaDonMacDinh),
         request.GhiChuHoaDonMacDinh,
         request.IdLoaiKhach,
         request.NganhNghe,
         request.KhuCongNghiep,
         request.NguonGocKhachHang,
         request.SR,
         request.SR_DangKy,
         request.SR2,
         request.SR2_DangKy,
         request.SA,
         request.SA_DangKy,
         request.QuanLy,
         request.BU,
         request.GhiChuKhachHang,
         request.HoSoThanhToan,
         request.IdDieuKhoanThanhToan,
         request.IdDieuKhoanThanhToanNoiBo,
         TinhTrangHoatDong.FromValue(request.TinhTrangHoatDong),
         request.NguoiDaiDien,
         request.ChucVuNguoiDaiDien,
         request.CMNDNguoiDaiDien,
         request.CanHDNT,
         request.DaCoHDNT,
         request.KyPO,
         request.DanhGiaKhachHang,
         request.NgungCapHang,
         request.GhiChuCongNo,
         request.DongDau,
         InTheoMauMacDinh.FromValue(request.InTheoMauMacDinh),
         request.KhoMacDinh,
         TemMacDinh.FromValue(request.TemMacDinh),
         request.GiayChungNhanDauTu,
         request.CanGiayChungNhanDauTu,
         ngayChungNhanDauTu,
         request.CanYeuCauXacNhanCongNo,
         request.HienGiaKhiInPhieuXuatKho,
         request.DSE,
         VendorStatus.FromValue(request.VendorStatus),
         request.HeThongKhachHang,
         request.MangKinhDoanh,
         taiKhoanNganHangKhachHang,
         addKhachHangLienHe);
        await _khachHangRepository.Add(addKhachHang);
        return Result.Success($"Tạo thành công khách hàng: {addKhachHang.MaKhachHang}");
    }
}
