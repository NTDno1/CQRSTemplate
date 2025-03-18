namespace ERP.Share.DTO;
public class AddTaiKhoanNganHangDTO
{
    public string SoTaiKhoan { get; set; }
    public string LoaiTaiKhoan { get; set; }
    public string TenTaiKhoan { get; set; }
    public string NganHang { get; set; }
    public string ChiNhanh { get; set; }
    public string TinhThanhPho { get; set; }
    public string HinhThucThanhToan { get; set; }
}

public class AddKhachHangLienHeDTO
{
    public string TenLienHe { get; set; }
    public string VaiTro { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }
    public string TinhTrang { get; set; }
    public string GhiChu { get; set; }
}

public class UpdateKhachHangLienHeDTO
{
    public Ulid Id { get; set; }
    public string TenLienHe { get; set; }
    public string VaiTro { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }
    public string TinhTrang { get; set; }
    public string GhiChu { get; set; }
}

public class UpdateTaiKhoanNganHangDTO
{
    public Ulid Id { get; set; }
    public string SoTaiKhoan { get; set; }
    public string LoaiTaiKhoan { get; set; }
    public string TenTaiKhoan { get; set; }
    public string NganHang { get; set; }
    public string ChiNhanh { get; set; }
    public string TinhThanhPho { get; set; }
    public string HinhThucThanhToan { get; set; }
}

public class UpdatePhanHoiKhachHangDTO
{
    public Ulid Id { get; set; }
    public string NgayPhanHoi { get; set; }
    public string IdUserPhanHoi { get; set; }
    public string NoiDungPhanHoi { get; set; }
    public Ulid IdKhachHang { get; set; }
    public string LoaiPhanHoi { get; set; }
    public bool CoGiaTri { get; set; }
}

public class DanhGiaKhachHangDTO
{
    public Ulid Id { get; set; }
    public string? NganhNghe { get; set; }
    public int NamThanhLap { get; set; }
    public int SoLuongNhanVien { get; set; }
    public string? NguoiQuyetDinhMuaHang { get; set; }
    public string? SanPhamQuanTam { get; set; }
    public string? HangQuanTam { get; set; }
    public bool? CoNhaXuong { get; set; }
    public int SanLuongSanXuat { get; set; }
    public string? DoiThuCanhTranh { get; set; }
    public string? CoHoiPhatTrien { get; set; }
    public string? HopDongDaKy { get; set; }
    public Ulid? IdCTKMThamGia { get; set; }
    public string? DuAnTiemNangSapToi { get; set; }
    public string? TinhHinhTaiChinh { get; set; }
    public string? LuuY { get; set; }
    public Ulid? IdKhachHang { get; set; }
}

public class KhaiHaiQuanDTO
{
    public Ulid Id { get; set; }
    public Ulid IdKhachHang { get; set; }
    public string ChiCucHaiQuan { get; set; }
    public string MaDiaDiemLuuKhoHangChoThongQuanDuKien { get; set; }
    public string DiaDiemDoHang { get; set; }
    public string DiaDiemDichChoVanChuyenBaoThue { get; set; }
    public string? GhiChuLamHaiQuanMayDau { get; set; }
    public string? GhiChuChungTuNhapKhachHangCanCheck { get; set; }
    public string? ThongTinLienHeKhachHang { get; set; }
    public string? BoChungTuBanCung { get; set; }
    public string? TermOfSale { get; set; }
    public string? TenTiengAnh { get; set; }
}
