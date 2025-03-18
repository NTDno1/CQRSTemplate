namespace ERP.Share.Responses.BaoGiaRespone;
public class BaoGiaRespone
{
    public string Id { get; set; }

    public string SoBaoGia { get; set; }

    public string? NgayBaoGia { get; set; }

    public string IdKhachHang { get; set; }

    public string IdLienHe { get; set; }

    public string HieuLucBaoGia { get; set; }

    public string IdDieuKhoanThanhToan { get; set; }

    public string IdDieuKhoanThanhToanKhachHang { get; set; }

    public decimal ThanhTienNet { get; set; }

    public decimal ThanhTienHang0 { get; set; }

    public decimal TienThueGTGT0 { get; set; }

    public decimal ThanhTienHang8 { get; set; }

    public decimal TienThueGTGT8 { get; set; }

    public decimal ThanhTienHang10 { get; set; }

    public decimal TienThueGTGT10 { get; set; }

    public decimal TongThanhTien { get; set; }

    public decimal TienThuDichVuVat { get; set; }

    public string LoaiDon { get; set; }

    public string TrangThaiDon { get; set; }

    public string LyDoTruot { get; set; }

    public string? NgayTruot { get; set; }

    public string TrangThaiDuyet { get; set; }

    public string LyDoHuyDuyet { get; set; }

    public string KhaNangTrung { get; set; }

    public bool IsBaoGiaQuanTrong { get; set; }

    public string SR { get; set; }

    public string SR2 { get; set; }

    public string SA { get; set; }

    public string IdCTKM { get; set; }

    public string ChiNhanh { get; set; }

    public string KhoXuLy { get; set; }

    public string DiaChiGiaoHang { get; set; }

    public string NguoiNhanHang { get; set; }

    public string? NgayDuKienGiao { get; set; }

    public int SoLuongComment { get; set; }

    public bool CanDuyetCMDuoi20 { get; set; }

    public string NguoiDuyetCMDuoi20 { get; set; }

    public string? NgayDuyetCMDuoi20 { get; set; }

    public string GhiChuDuyetCMDuoi20 { get; set; }

    public string IASHoTro1 { get; set; }

    public string IASHoTro2 { get; set; }

    public bool IsDeleted { get; set; }

    public string? NgayXoa { get; set; }

    public string? NgayTao { get; set; }

    public string? NgaySua { get; set; }

    public string NguoiTao { get; set; }

    public string NguoiSua { get; set; }

    public string TenKhachHang { get; set; }

    public string TenKhLienHe { get; set; }

    public string DieuKhoanThanhToan { get; set; }

    public string TenNguoiDuyetCMDuoi20 { get; set; }

    public string TenNguoiNhanHang { get; set; }

    public string TenNguoiSua { get; set; }

    public string TenNguoiTao { get; set; }
}

public class DetailBaoGiaRespone
{
    public string Id { get; set; }

    public string SoBaoGia { get; set; }

    public string? NgayBaoGia { get; set; }

    public string IdKhachHang { get; set; }

    public string IdLienHe { get; set; }

    public string HieuLucBaoGia { get; set; }

    public string IdDieuKhoanThanhToan { get; set; }

    public string IdDieuKhoanThanhToanKhachHang { get; set; }

    public decimal ThanhTienNet { get; set; }

    public decimal ThanhTienHang0 { get; set; }

    public decimal TienThueGTGT0 { get; set; }

    public decimal ThanhTienHang8 { get; set; }

    public decimal TienThueGTGT8 { get; set; }

    public decimal ThanhTienHang10 { get; set; }

    public decimal TienThueGTGT10 { get; set; }

    public decimal TongThanhTien { get; set; }

    public decimal TienThuDichVuVat { get; set; }

    public string LoaiDon { get; set; }

    public string TrangThaiDon { get; set; }

    public string LyDoTruot { get; set; }

    public string? NgayTruot { get; set; }

    public string TrangThaiDuyet { get; set; }

    public string LyDoHuyDuyet { get; set; }

    public string KhaNangTrung { get; set; }

    public bool IsBaoGiaQuanTrong { get; set; }

    public string SR { get; set; }

    public string SR2 { get; set; }

    public string SA { get; set; }

    public string IdCTKM { get; set; }

    public string ChiNhanh { get; set; }

    public string KhoXuLy { get; set; }

    public string DiaChiGiaoHang { get; set; }

    public string NguoiNhanHang { get; set; }

    public string? NgayDuKienGiao { get; set; }

    public int SoLuongComment { get; set; }

    public bool CanDuyetCMDuoi20 { get; set; }

    public string NguoiDuyetCMDuoi20 { get; set; }

    public string? NgayDuyetCMDuoi20 { get; set; }

    public string GhiChuDuyetCMDuoi20 { get; set; }

    public string IASHoTro1 { get; set; }

    public string IASHoTro2 { get; set; }

    public bool IsDeleted { get; set; }

    public string? NgayXoa { get; set; }

    public string? NgayTao { get; set; }

    public string? NgaySua { get; set; }

    public string NguoiTao { get; set; }

    public string NguoiSua { get; set; }

    public string TenKhachHang { get; set; }

    public string TenKhLienHe { get; set; }

    public string DieuKhoanThanhToan { get; set; }

    public string TenNguoiDuyetCMDuoi20 { get; set; }

    public string TenNguoiNhanHang { get; set; }

    public string TenNguoiSua { get; set; }

    public string TenNguoiTao { get; set; }

    public List<BaoGiaChiTietResopne> BaoGiaChiTietResopnes { get; set; }
}

public class BaoGiaChiTietResopne
{
    public string Id { get; set; }
    public string IdBaoGia { get; set; }
    public string IdHangHoa { get; set; }
    public string MaDieuChinh { get; set; }
    public string TenHang { get; set; }
    public string IdNhomHang { get; set; }
    public string ItemCode { get; set; }
    public int SoLuong { get; set; }
    public string DonViTinh { get; set; }
    public string BaoHanh { get; set; }
    public decimal DonGiaNet { get; set; }
    public decimal DonGiaBan { get; set; }
    public decimal DonGiaMoi { get; set; }
    public decimal DonGiaDichVuVat { get; set; }
    public decimal ThanhTienNet { get; set; }
    public decimal ThanhTienHang { get; set; }
    public decimal ThueGTGT { get; set; }
    public decimal ThueDichVuVat { get; set; }
    public decimal TongThanhTien { get; set; }
    public decimal PhanTramCM { get; set; }
    public decimal ThueTNDN { get; set; }
    public decimal TienThueTNDN { get; set; }
    public decimal TienKhachNhan { get; set; }
    public string ThoiGianGiaoHang { get; set; }
    public string IdKhoXuLy { get; set; }
    public string GhiChu { get; set; }
    public int SoLuongTon { get; set; }
    public string HinhAnhMinhHoa { get; set; }
    public bool Discontinue { get; set; }
    public string NoiDungYeuCauHoiHang { get; set; }
    public string MaXinGia { get; set; }
    public string TrangThaiDuyetGia { get; set; }
    public decimal GiaBanThucTe1 { get; set; }
    public decimal GiaBanThucTe2 { get; set; }
    public decimal GiaBanThucTe3 { get; set; }
    public decimal GiaBanThucTe4 { get; set; }
    public decimal GiaGMinTinhThuong { get; set; }
    public bool LaMaKhuyenMai { get; set; }
    public bool LaMaLo { get; set; }
    public bool IsDeleted { get; set; }
    public string? NgayXoa { get; set; }
    public string? NgayTao { get; set; }
    public string? NgaySua { get; set; }
    public string NguoiTao { get; set; }
    public string NguoiSua { get; set; }

    public string TenHangHoa { get; set; }
    public string MaNhomHang { get; set; }
    public string TenNguoiSua { get; set; }
    public string TenNguoiTao { get; set; }
}
