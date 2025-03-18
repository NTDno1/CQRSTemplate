using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.WareHouses.NhapKho;
public sealed class NhapKhoChiTiet : AggregateRoot, ISoftDelete
{
    private readonly List<NhapKhoSerial> _nhapKhoSerials;
    public NhapKhoChiTiet()
    {
        _nhapKhoSerials = [];
    }

    public Ulid IdNhapKho { get; private set; }
    public Ulid IdHangHoa { get; private set; }
    public string MaDieuChinh { get; private set; }
    public string TenHang { get; private set; }
    public string TkNo { get; private set; }
    public string TkCo { get; private set; }
    public string TkGiaVon { get; private set; }
    public string TkThue { get; private set; }
    public decimal DonGia { get; private set; } = decimal.Zero;
    public string DonViTinh { get; private set; }
    public decimal SoLuong { get; private set; } = decimal.Zero;
    public decimal ThanhTienHang { get; private set; } = decimal.Zero;
    public decimal QuyDoi { get; private set; } = decimal.Zero;
    public string? DienGiaiThue { get; private set; }
    public int ThueGtgt { get; private set; } = 0;
    public decimal TienThueGtgt { get; private set; } = decimal.Zero;
    public string? SoHoaDon { get; private set; }
    public DateTime? NgayHoaDon { get; private set; }
    public decimal DonGiaVon { get; private set; } = decimal.Zero;
    public decimal TienVon { get; private set; } = decimal.Zero;
    public decimal GiaTriNhapKho { get; private set; } = decimal.Zero;
    public string TkKho { get; private set; }
    public string MaKhoCon { get; private set; }
    public decimal TongThanhTien { get; private set; } = decimal.Zero;
    public string? GhiChu { get; private set; }
    public bool DaTraLaiNhaCungCap { get; private set; } = false;
    public decimal SoLuongDaTra { get; private set; } = decimal.Zero;
    public Ulid? IdCtTraLai { get; private set; }
    public string? IdTechMuaHang { get; private set; }
    public string? MaVach { get; private set; }
    public bool DaXepHang { get; private set; } = false;
    public decimal SoLuongDaXep { get; private set; } = decimal.Zero;
    public decimal SoTienDaThanhToan { get; private set; } = decimal.Zero;
    public bool DaThanhToan { get; private set; } = false;
    public decimal DonGiaBaoDiNet { get; private set; } = decimal.Zero;
    public decimal DonGiaUsd { get; private set; }
    public decimal PhiVC { get; private set; } = decimal.Zero;
    public decimal TiGia { get; private set; } = decimal.Zero;
    public decimal ThanhTienTruocThue { get; private set; } = decimal.Zero;
    public decimal TongTienTruocThue { get; private set; } = decimal.Zero;
    public decimal TongTienTinhThue { get; private set; } = decimal.Zero;
    public int ThueNhapKhau { get; private set; } = 0;
    public decimal TienThueNhapKhau { get; private set; } = decimal.Zero;
    public decimal DonGiaPhiVanChuyen { get; private set; } = decimal.Zero;
    public decimal ThanhTienUsd { get; private set; } = decimal.Zero;
    public string LoaiTien { get; private set; }
    public int ChietKhauKhac { get; private set; } = 0;
    public decimal SoTienChietKhau { get; private set; } = decimal.Zero;
    public decimal TienVatChietKhau { get; private set; } = decimal.Zero;
    public decimal TongTienTinhCongNo { get; private set; }
    public decimal TongTienTinhGiaVon { get; private set; } = decimal.Zero;
    public decimal QuyDoiTongTienTinhCongNo { get; private set; } = decimal.Zero;
    public bool XacNhanChietKhau { get; private set; } = false;
    public decimal TongTienChietKhau { get; private set; } = decimal.Zero;
    public bool DaDoiTru { get; private set; } = false;
    public decimal SoTienDoiTru { get; private set; } = decimal.Zero;
    public string? GhiChuCongNoCt { get; private set; }
    public bool PrCanXuLyDauVao { get; private set; } = false;
    public string? PrTichXuLyDauVao { get; private set; }
    public DateTime? NgayThuMuaXuLyDauVao { get; private set; }
    public bool KtTichHoaDonCham { get; private set; } = false;
    public string? KtTichCham { get; private set; }
    public DateTime? NgayKtTichHoaDonCham { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }
    public NhapKho WhNhapKho { get; private set; }
    public IReadOnlyCollection<NhapKhoSerial> NhapKhoSerials => _nhapKhoSerials.AsReadOnly();
}
