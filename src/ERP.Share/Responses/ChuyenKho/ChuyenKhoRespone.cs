namespace ERP.Share.Responses.ChuyenKho;
public class ChuyenKhoChiTietRespone
{
    public int Id { get; set; }

    public string? SoChungTu { get; set; }

    public string? MaHang { get; set; }

    public string? MaDieuChinh { get; set; }

    public string? XuatTaiKho { get; set; }

    public string? NhapTaiKho { get; set; }

    public decimal SoLuong { get; set; }

    public string TkNo { get; set; } = null!;

    public string TkCo { get; set; } = null!;

    public decimal DonGia { get; set; }

    public decimal ThanhTien { get; set; }

    public decimal SoLuongDaNhat { get; set; }

    public string? NguoiNhatHang { get; set; }

    public string? NgayNhatHang { get; set; }
}

public class ChuyenKhoRespone
{
    public string Id { get; set; }
    public string MaChuyenKho { get; set; }
    public string NgayChungTu { get; set; }
    public string DienGiai { get; set; }
    public string TrucThuoc { get; set; }
    public string HinhThucChuyen { get; set; }
    public string TrangThai { get; set; }
    public string SoBill { get; set; }
    public string IdKhoXuatHang { get; set; }
    public string IdKhoNhanHang { get; set; }
    public string? NgayXacNhanXuat { get; set; }
    public string NguoiXacNhanXuat { get; set; }
    public string NguoiNhanHang { get; set; }
    public string? ThoiGianNhanHang { get; set; }
    public bool CanXuatHoaDon { get; set; }
    public string SoHoaDon { get; set; }
    public string NgayTao { get; set; }
    public string NgaySua { get; set; }
    public string NguoiTao { get; set; }
    public string NguoiSua { get; set; }
    public string TenNguoiTao { get; set; }
    public string TenNguoiSua { get; set; }
    public string SoChungTuXuatKho { get; set; }
    public string SoChungTuNhapKho { get; set; }
    public string TenNguoiXacNhanXuat { get; set; }
    public string TenNguoiNhanHang { get; set; }

}

public class DetailChuyenKhoRespone
{
    public string Id { get; set; }
    public string NgayChungTu { get; set; }
    public string DienGiai { get; set; }
    public string TrucThuoc { get; set; }
    public string HinhThucChuyen { get; set; }
    public string SoBill { get; set; }
    public string KhoXuatHang { get; set; }
    public string KhoNhanHang { get; set; }
    public string TrangThai { get; set; }
    public string? NgayXacNhanXuat { get; set; }
    public string NguoiXacNhanXuat { get; set; }
    public string NguoiNhanHang { get; set; }
    public string? ThoiGianNhanHang { get; set; }
    public bool CanXuatHoaDon { get; set; }
    public string SoHoaDon { get; set; }
    public string NguoiTao { get; set; }
    public string TenNguoiTao { get; set; }
    public string NgayTao { get; set; }
    public string TenNguoiXacNhanXuat { get; set; }
    public string? NgaySua { get; set; }
    public string TenNguoiSua { get; set; }
    public List<ChuyenKhoChiTietRespone> ChuyenKhoChiTietRespone { get; set; }
}
