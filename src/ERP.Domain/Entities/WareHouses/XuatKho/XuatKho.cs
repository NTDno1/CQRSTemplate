using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Sales.KhachHang;

namespace ERP.Domain.Entities.WareHouses.XuatKho;
public sealed class XuatKho : AggregateRoot, ISoftDelete
{
    private readonly List<XuatKhoChiTiet> _xuatKhoChiTiet;

    public XuatKho()
    {
        _xuatKhoChiTiet = [];
    }

    public string SoChungTu { get; private set; }
    public DateTime NgayChungTu { get; private set; }
    public DateTime? NgayTinhCongNo { get; private set; }
    public DateTime? NgayNghiemThu { get; private set; }
    public DateTime? NgayHoaDonHaiQuan { get; private set; }
    public LoaiXuatKho LoaiXuatKho { get; private set; }
    public string? TenNguoiNhan { get; private set; }
    public string? SdtNguoiNhan { get; private set; }
    public string? DiaChiGiaoHang { get; private set; }
    public string LyDoXuat { get; private set; }
    public string? SR { get; private set; }
    public string? SA { get; private set; }
    public string? TrucThuoc { get; private set; }
    public string MaDoiTuong { get; private set; }
    public Ulid? IdBaoGia { get; private set; }
    public decimal ThanhTienHang { get; private set; } = decimal.Zero;
    public decimal TienHang0 { get; private set; } = decimal.Zero;
    public decimal TienHang8 { get; private set; } = decimal.Zero;
    public decimal TienHang10 { get; private set; } = decimal.Zero;
    public decimal TienThue_GTGT { get; private set; } = decimal.Zero;
    public decimal TienThue_GTGT0 { get; private set; } = decimal.Zero;
    public decimal TienThue_GTGT8 { get; private set; } = decimal.Zero;
    public decimal TienThue_GTGT10 { get; private set; } = decimal.Zero;
    public decimal TongTien { get; private set; } = decimal.Zero;
    public string? HoaDonChungTu { get; private set; }
    public string? TenCongTyXuatHoaDon { get; private set; }
    public string? DiaChiXuatHoaDon { get; private set; }
    public string? Mst { get; private set; }
    public string? EmailNhanHoaDon { get; private set; }
    public bool DaXuatHoaDon { get; private set; }
    public string? XuatHoaDonTuCongTy { get; private set; }
    public string? EmailHoaDon { get; private set; }
    public string? SoHoaDonThucTe { get; private set; }
    public DateTime? NgayHoaDon { get; private set; }
    public bool YeuCauXuatHoaDon { get; private set; }
    public DateTime? ThoiGianTichYeuCauXuatHD { get; private set; }
    public string? GhiChuHoaDon { get; private set; }
    public bool DaGhiSo { get; private set; }
    public DateTime? NgayGhiSo { get; private set; }
    public string? NguoiGhiSo { get; private set; }
    public bool Khoa { get; private set; }
    public string? SoPoKhach { get; private set; }
    public string? FileDinhKem { get; private set; }
    public string? GhiChuChoGiaoNhan { get; private set; }
    public string? HinhThucGiaoHang { get; private set; }
    public string? ThongTinNhaXe { get; private set; }
    public string? SoBill { get; private set; }
    public bool DaPacking { get; private set; }
    public bool DangPacking { get; private set; }
    public string? TemXuatTheo { get; private set; }
    public decimal TrongLuong { get; private set; } = decimal.Zero;
    public string? SoKien { get; private set; }
    public string? ViTriDeHang { get; private set; }
    public bool DaGiaoHang { get; private set; }
    public string? MaVach { get; private set; }
    public string? BenChiuPhi { get; private set; }
    public string? KhoXuLy { get; private set; }
    public InTheoMauMacDinh InTheoMau { get; private set; }
    public bool DaThanhToan { get; private set; }
    public decimal SoTienDaThanhToan { get; private set; } = decimal.Zero;
    public Ulid IdDieuKhoanThanhToan { get; private set; }
    public Ulid IdDieuKhoanThanhToanNoiBo { get; private set; }
    public string? SR2 { get; private set; }
    public decimal ThanhTienNet { get; private set; } = decimal.Zero;
    public decimal TongTienChenhLech { get; private set; } = decimal.Zero;
    public decimal TongChiPhiHoaDon { get; private set; } = decimal.Zero;
    public decimal ThucNhanCuaKhach { get; private set; } = decimal.Zero;
    public decimal SoTienDaThanhToanCM { get; private set; } = decimal.Zero;
    public bool DaInPhieu { get; private set; }
    public bool HienGiaTien { get; private set; }
    public bool DaChuyenCongNoSan { get; private set; }
    public decimal SoTienThuHo { get; private set; } = decimal.Zero;
    public string? NguoiXacNhan { get; private set; }
    public bool IsTachPhieu { get; private set; }
    public decimal SoTienCanThu { get; private set; } = decimal.Zero;
    public decimal TienThuDichVuVat { get; private set; } = decimal.Zero;
    public decimal DonGiaDichVuVat { get; private set; } = decimal.Zero;
    public bool YeuCauPxkHaiQuan { get; private set; }
    public bool DaXuatPxkHaiQuan { get; private set; }
    public DateTime? NgayPxkHaiQuan { get; private set; }
    public string? GhiChuPxkHaiQuan { get; private set; }
    public DateTime? ThoiGianTichXuatPxkHaiQuan { get; private set; }
    public string? MaSoPxkHaiQuan { get; private set; }
    public string? NguonGocDonHang { get; private set; }
    public Ulid? IdCtkm { get; private set; }
    public bool DaChotCtkm { get; private set; }
    public string? MaVoucher { get; private set; }
    public string? TenSanTmdt { get; private set; }
    public string? TenShopTmdt { get; private set; }
    public DateTime? NgayTaoTmdt { get; private set; }
    public string? MaVanDonViettelPost { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }
    public IReadOnlyCollection<XuatKhoChiTiet> XuatKhoChiTiets => _xuatKhoChiTiet.AsReadOnly();
}
