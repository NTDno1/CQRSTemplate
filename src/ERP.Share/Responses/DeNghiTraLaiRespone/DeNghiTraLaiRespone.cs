
namespace ERP.Share.Responses.DeNghiTraLaiRespone;
public class DeNghiTraLaiRespone
{
    public string Id { get; set; }
    public string MaDeNghi { get; private set; }

    public string NgayDeNghi { get; private set; }
    public string NguoiDeNghi { get; private set; }
    public string MaNhatHang { get; private set; }
    public string SoPhieuXuatKho { get; private set; }
    public string NguoiTraLai { get; private set; }
    public string LyDoDeNghi { get; private set; }
    //
    public string? LeaderDuyet { get; init; }
    public string? NgayLeaderDuyet { get; init; }
    public string TrangThaiLeaderDuyet { get; init; }
    public string? GhiChuLeaderDuyet { get; init; }
    //
    public string? KyThuatDuyet { get; init; }
    public string? NgayKyThuatDuyet { get; init; }
    public string TrangThaiKyThuatDuyet { get; init; }
    public string? GhiChuKyThuatDuyet { get; init; }
    //
    public string? GhiChuDonHang { get; private set; }
    public bool CanDiLayHang { get; private set; }
    public string DiaChiLayHang { get; private set; }
    public string NguoiGiaoHangThucTe { get; private set; }
    public string? GhiChuGiaoNhan { get; private set; }
    public bool DaNhapKho { get; private set; }
    public string? SoPhieuNhapKho { get; private set; }
    public string TrucThuoc { get; private set; }
    public string? IdKhoNhapHang { get; private set; }
    public string HinhThucTraLai { get; private set; }
    public decimal? SoTienPhiNhapLai { get; private set; }
    public string? LyDoThuPhiNhapLai { get; private set; }

    public static implicit operator DeNghiTraLaiRespone(DetailDeNghiTraLaiRespone v) => throw new NotImplementedException();
}

public class DetailDeNghiTraLaiRespone
{
    public string Id { get; set; }
    public string MaDeNghi { get; private set; }

    public string NgayDeNghi { get; private set; }
    public string NguoiDeNghi { get; private set; }
    public string MaNhatHang { get; private set; }
    public string SoPhieuXuatKho { get; private set; }
    public string NguoiTraLai { get; private set; }
    public string LyDoDeNghi { get; private set; }
    //
    public string? LeaderDuyet { get; init; }
    public string? NgayLeaderDuyet { get; init; }
    public string TrangThaiLeaderDuyet { get; init; }
    public string? GhiChuLeaderDuyet { get; init; }
    //
    public string? KyThuatDuyet { get; init; }
    public string? NgayKyThuatDuyet { get; init; }
    public string TrangThaiKyThuatDuyet { get; init; }
    public string? GhiChuKyThuatDuyet { get; init; }
    //
    public string? GhiChuDonHang { get; private set; }
    public bool CanDiLayHang { get; private set; }
    public string DiaChiLayHang { get; private set; }
    public string NguoiGiaoHangThucTe { get; private set; }
    public string? GhiChuGiaoNhan { get; private set; }
    public bool DaNhapKho { get; private set; }
    public string? SoPhieuNhapKho { get; private set; }
    public string TrucThuoc { get; private set; }
    public string? IdKhoNhapHang { get; private set; }
    public string HinhThucTraLai { get; private set; }
    public decimal? SoTienPhiNhapLai { get; private set; }
    public string? LyDoThuPhiNhapLai { get; private set; }
    public string TenNguoiTao { get; set; }
    public string TenNguoiSua { get; set; }
    public string TenNguoiDeNghi { get; set; }
    public string TenNguoiTraLai { get; set; }
    public string TenNguoiGiaoHangThucTe { get; set; }
    public string SoChungTuNhapKho { get; set; }
    public IEnumerable<DeNghiTraLaiChiTietRespone>? DeNghiTraLaiChiTiet { get; set; }
}

public class DeNghiTraLaiChiTietRespone
{
    public string IdDeNghiTraLai { get; private set; }
    public string IdHangHoa { get; private set; }
    public string MaDieuChinh { get; private set; }
    public int SoLuong { get; private set; }
    public decimal DonGiaBan { get; private set; }
    public decimal DonGiaVon { get; private set; }
    public string GhiChu { get; private set; }
    public decimal ThueGTGT { get; private set; }
    public string IdChiTietXuatKho { get; private set; }
    public bool DaNhapKho { get; private set; }
    public int SoLuongDaNhap { get; private set; }
}
