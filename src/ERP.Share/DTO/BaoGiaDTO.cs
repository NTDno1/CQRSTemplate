namespace ERP.Share.DTO;
public class AddBaoGiaChiTietDTO
{
    public Ulid IdHangHoa { get; set; }
    public string? MaDieuChinh { get; set; }
    public string? TenHang { get; set; }
    public Ulid? IdNhomHang { get; set; }
    public string? ItemCode { get; set; }
    public int SoLuong { get; set; }
    public string DonViTinh { get; set; }
    public int BaoHanh { get; set; }
    public decimal DonGiaNet { get; set; }
    public decimal DonGiaBan { get; set; }
    public decimal DonGiaMoi { get; set; }
    public decimal DonGiaDichVuVat { get; set; }
    public decimal? ThanhTienNet { get; set; }
    public decimal? ThanhTienHang { get; set; }
    public decimal? ThueGTGT { get; set; }
    public decimal? ThueDichVuVat { get; set; }
    public decimal? TongThanhTien { get; set; }
    public decimal? PhanTramCM { get; set; }
    public decimal? ThueTNDN { get; set; }
    public decimal? TienThueTNDN { get; set; }
    public decimal? TienKhachNhan { get; set; }
    public string ThoiGianGiaoHang { get; set; }
    public Ulid? IdKhoXuLy { get; set; }
    public string? GhiChu { get; set; }
    public int? SoLuongTon { get; set; }
    public string? HinhAnhMinhHoa { get; set; }
    public bool Discontinue { get; set; }
    public string? NoiDungYeuCauHoiHang { get; set; }
    public string? MaXinGia { get; set; }
    public string? TrangThaiDuyetGia { get; set; }
    public decimal? GiaBanThucTe1 { get; set; }
    public decimal? GiaBanThucTe2 { get; set; }
    public decimal? GiaBanThucTe3 { get; set; }
    public decimal? GiaBanThucTe4 { get; set; }
    public decimal? GiaGMinTinhThuong { get; set; }
    public bool LaMaKhuyenMai { get; set; }
    public bool LaMaLo { get; set; }
}

public class UpdateBaoGiaChiTietDTO
{
    public Ulid? Id { get; set; }

    public Ulid? IdHangHoa { get; set; }

    public string? MaDieuChinh { get; set; }

    public string? TenHang { get; set; }

    public Ulid? IdNhomHang { get; set; }

    public string? ItemCode { get; set; }

    public int? SoLuong { get; set; }

    public string? DonViTinh { get; set; }

    public int? BaoHanh { get; set; }

    public decimal? DonGiaNet { get; set; }

    public decimal? DonGiaBan { get; set; }

    public decimal? DonGiaMoi { get; set; }

    public decimal? DonGiaDichVuVat { get; set; }

    public decimal? ThanhTienNet { get; set; }

    public decimal? ThanhTienHang { get; set; }

    public decimal? ThueGTGT { get; set; }

    public decimal? ThueDichVuVat { get; set; }

    public decimal? TongThanhTien { get; set; }

    public decimal? PhanTramCM { get; set; }

    public decimal? ThueTNDN { get; set; }

    public decimal? TienThueTNDN { get; set; }

    public decimal? TienKhachNhan { get; set; }

    public string ThoiGianGiaoHang { get; set; }

    public Ulid? IdKhoXuLy { get; set; }

    public string? GhiChu { get; set; }

    public int? SoLuongTon { get; set; }

    public string? HinhAnhMinhHoa { get; set; }

    public bool? Discontinue { get; set; }

    public string? NoiDungYeuCauHoiHang { get; set; }

    public string? MaXinGia { get; set; }

    public string? TrangThaiDuyetGia { get; set; }

    public decimal? GiaBanThucTe1 { get; set; }

    public decimal? GiaBanThucTe2 { get; set; }

    public decimal? GiaBanThucTe3 { get; set; }

    public decimal? GiaBanThucTe4 { get; set; }

    public decimal? GiaGMinTinhThuong { get; set; }

    public bool? LaMaKhuyenMai { get; set; }

    public bool? LaMaLo { get; set; }
}
