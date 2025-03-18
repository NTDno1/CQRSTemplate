using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.WareHouses.XuatKho;
public sealed class XuatKhoChiTiet : AggregateRoot
{
    private readonly List<XuatKhoSerial> _xuatKhoSerials;
    public XuatKhoChiTiet()
    {
        _xuatKhoSerials = [];
    }
    public Ulid IdXuatKho { get; set; }
    public Ulid IdHangHoa { get; set; }
    public string MaDieuChinh { get; set; }
    public string TenHang { get; set; }
    public string Dvt { get; set; }
    public decimal SoLuong { get; set; } = decimal.Zero;
    public string? TkCo { get; set; }
    public string? TkNo { get; set; }
    public string? TkGiaVon { get; set; }
    public string? TkKho { get; set; }
    public decimal DonGiaBan { get; set; } = decimal.Zero;
    public decimal ThanhTienHang { get; set; } = decimal.Zero;
    public decimal DonGiaVon { get; set; } = decimal.Zero;
    public decimal TienVon { get; set; } = decimal.Zero;
    public decimal QuyDoi { get; set; } = decimal.Zero;
    public string MaKhoCon { get; set; }
    public int ThueGtgt { get; set; } = 0;
    public decimal TienThueGtgt { get; set; } = decimal.Zero;
    public decimal TongThanhTien { get; set; }
    public string? TaiKhoanThue { get; set; }
    public string? GhiChu { get; set; }
    public int? IdCtBh { get; set; }
    public bool DaTraLaiHang { get; set; } = false;
    public decimal SoLuongDaTra { get; set; } = decimal.Zero;
    public bool DaGhiSo { get; set; } = false;
    public decimal SlCnDaNhap { get; set; } = decimal.Zero;
    public bool CnDaNhapHet { get; set; } = false;
    public string? MaNhomHang { get; set; }
    public string? MaKhoBanDau { get; set; }
    public bool DaPacking { get; set; } = false;
    public decimal SoLuongPacking { get; set; } = decimal.Zero;
    public decimal DonGiaBaoDiNet { get; set; } = decimal.Zero;
    public decimal ThanhTienNet { get; set; } = decimal.Zero;
    public string? LoaiTien { get; set; }
    public decimal TyGia { get; set; } = decimal.Zero;
    public decimal CM { get; set; } = decimal.Zero;
    public int ThueTndn { get; set; } = 0;
    public decimal TienThueTndn { get; set; } = decimal.Zero;
    public decimal KhachNhanDuoc { get; set; } = decimal.Zero;
    public decimal TongTienTinhCongNo { get; set; } = decimal.Zero;
    public decimal QuyDoiTongTienTinhCongNo { get; set; } = decimal.Zero;
    public decimal ChietKhauKhac { get; set; } = decimal.Zero;
    public decimal SoTienChietKhau { get; set; } = decimal.Zero;
    public decimal TienVatChietKhau { get; set; } = decimal.Zero;
    public bool XacNhanChietKhau { get; set; } = false;
    public string? LoSanXuat { get; set; }
    public string? SoPoMaHang { get; set; }
    public bool HangGiamGia { get; set; } = false;
    public string? LyDo { get; set; }
    public string? CachXuLy { get; set; }
    public bool DaXuLy { get; set; } = false;
    public string? NguoiXuLy { get; set; }
    public DateTime? NgayXuLy { get; set; }
    public decimal SoTienDoiTruCT { get; set; } = decimal.Zero;
    public bool DaDoiTruCt { get; set; } = false;
    public string? GhiChuCongNoCt { get; set; }
    public bool AnPhieu { get; set; } = false;
    public bool DaDuyetHoaDon { get; set; } = false;
    public bool CanDuyetHoaDon { get; set; } = false;
    public string? LyDoDuyetXuatHoaDon { get; set; }
    public DateTime? NgayDuyetXuatHoaDon { get; set; }
    public string? KtDuyetXuatHoaDon { get; set; }
    public string? PrNoteHoaDonNcc { get; set; }
    public string? ErpNoteHoaDonNcc { get; set; }
    public bool SanDaNhat { get; set; } = false;
    public decimal TienThuDichVuVat { get; set; } = decimal.Zero;
    public decimal DonGiaDichVuVat { get; set; } = decimal.Zero;
    public decimal CmCu { get; set; } = decimal.Zero;
    public int BaoHanh { get; set; } = 0;
    public string? LoaiTinhTrangHH { get; set; }
    public DateTime? NgayDuKienHangVe { get; set; }
    public decimal SoLuongCoSan { get; set; } = decimal.Zero;
    public decimal SoLuongXuatHoaDon { get; set; } = decimal.Zero;
    public string? ItemCode { get; set; }
    public string? SoPoSamSung { get; set; }
    public bool IsMaQtCtkm { get; set; } = false;
    public decimal TroGiaShopee { get; set; } = decimal.Zero;
    public string? SoChungTuBaoHanh { get; set; }
    public XuatKho XuatKho { get; set; }
    public IReadOnlyCollection<XuatKhoSerial> XuatKhoSerials => _xuatKhoSerials.AsReadOnly();
}
