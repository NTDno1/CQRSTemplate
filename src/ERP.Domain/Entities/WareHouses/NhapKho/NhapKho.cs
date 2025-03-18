using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.WareHouses.NhapKho;
public sealed class NhapKho : AggregateRoot, ISoftDelete
{
    private readonly List<NhapKhoChiTiet> _nhapKhoChiTiets;
    public NhapKho()
    {
        _nhapKhoChiTiets = [];
    }

    public NhapKho(string soChungTu, DateTime ngayChungTu, DateTime ngayHoachToan, string trangThaiPhieu, LoaiNhapKho loaiNhapKho, string maDoiTuong, string? nguoiGiaoHang, string? dienGiai, string nhanVienMuaHang, decimal thanhTienHang, decimal tienThueGtgt, decimal tongTien, string trucThuoc, string? soHoaDonNhaCungCap, DateTime? ngayHoaDonNhaCungCap, string? maSoPo, bool khoa, string? khoNhanHang, bool daTraLaiNcc, bool daChiTien, decimal soTienDaChi, bool daDuHoaDon, decimal tongTienPhiVanChuyen, Ulid? idDieuKhoanThanhToan, Ulid? idDieuKhoanThanhToanNoiBo, TrangThaiHoaDon trangThaiHoaDon, string? ghiChuHoaDon, string? loaiHoaDon, bool isTachPhieu, string? saCare, string? srCare, decimal soTienDaDeNghiThanhToan, decimal tyGiaUsdRmb, decimal tiGiaRmbVanChuyen, decimal chiPhiSoVoiInvoice, string? maNhaCungCapNuocNgoai, decimal phiBank, decimal phiThongQuan, decimal phiXangDau, bool canDiLayHang, string? maVanDonLayHang, string? soBill, bool isDeleted, DateTime? ngayXoa)
    {
        Id = Ulid.NewUlid();
        SoChungTu = soChungTu;
        NgayChungTu = ngayChungTu;
        NgayHoachToan = ngayHoachToan;
        TrangThaiPhieu = trangThaiPhieu;
        LoaiNhapKho = loaiNhapKho;
        MaDoiTuong = maDoiTuong;
        NguoiGiaoHang = nguoiGiaoHang;
        DienGiai = dienGiai;
        NhanVienMuaHang = nhanVienMuaHang;
        ThanhTienHang = thanhTienHang;
        TienThueGtgt = tienThueGtgt;
        TongTien = tongTien;
        TrucThuoc = trucThuoc;
        SoHoaDonNhaCungCap = soHoaDonNhaCungCap;
        NgayHoaDonNhaCungCap = ngayHoaDonNhaCungCap;
        MaSoPo = maSoPo;
        Khoa = khoa;
        KhoNhanHang = khoNhanHang;
        DaTraLaiNcc = daTraLaiNcc;
        DaChiTien = daChiTien;
        SoTienDaChi = soTienDaChi;
        DaDuHoaDon = daDuHoaDon;
        TongTienPhiVanChuyen = tongTienPhiVanChuyen;
        IdDieuKhoanThanhToan = idDieuKhoanThanhToan;
        IdDieuKhoanThanhToanNoiBo = idDieuKhoanThanhToanNoiBo;
        TrangThaiHoaDon = trangThaiHoaDon;
        GhiChuHoaDon = ghiChuHoaDon;
        LoaiHoaDon = loaiHoaDon;
        IsTachPhieu = isTachPhieu;
        SaCare = saCare;
        SrCare = srCare;
        SoTienDaDeNghiThanhToan = soTienDaDeNghiThanhToan;
        TyGiaUsdRmb = tyGiaUsdRmb;
        TiGiaRmbVanChuyen = tiGiaRmbVanChuyen;
        ChiPhiSoVoiInvoice = chiPhiSoVoiInvoice;
        MaNhaCungCapNuocNgoai = maNhaCungCapNuocNgoai;
        PhiBank = phiBank;
        PhiThongQuan = phiThongQuan;
        PhiXangDau = phiXangDau;
        CanDiLayHang = canDiLayHang;
        MaVanDonLayHang = maVanDonLayHang;
        SoBill = soBill;
        IsDeleted = isDeleted;
        NgayXoa = ngayXoa;
    }

    public string SoChungTu { get; private set; }
    public DateTime NgayChungTu { get; private set; } = DateTime.Now;
    public DateTime NgayHoachToan { get; private set; } = DateTime.Now;
    public string TrangThaiPhieu { get; private set; }
    public LoaiNhapKho LoaiNhapKho { get; private set; }
    public string MaDoiTuong { get; private set; }

    public string? KtPhuTrach { get; private set; }

    public string? NguoiGiaoHang { get; private set; }
    public string? DienGiai { get; private set; }
    public string NhanVienMuaHang { get; private set; }
    public decimal ThanhTienHang { get; private set; } = decimal.Zero;
    public decimal TienThueGtgt { get; private set; } = decimal.Zero;
    public decimal TongTien { get; private set; } = decimal.Zero;
    public string TrucThuoc { get; private set; }
    public string? SoHoaDonNhaCungCap { get; private set; }
    public DateTime? NgayHoaDonNhaCungCap { get; private set; }
    public string? MaSoPo { get; private set; }
    public bool Khoa { get; private set; } = false;
    public string? KhoNhanHang { get; private set; }
    public bool DaTraLaiNcc { get; private set; } = false;
    public bool DaChiTien { get; private set; } = false;
    public decimal SoTienDaChi { get; private set; } = decimal.Zero;
    public bool DaDuHoaDon { get; private set; } = false;
    public decimal TongTienPhiVanChuyen { get; private set; } = decimal.Zero;
    public Ulid? IdDieuKhoanThanhToan { get; private set; }
    public Ulid? IdDieuKhoanThanhToanNoiBo { get; private set; }
    public TrangThaiHoaDon? TrangThaiHoaDon { get; private set; }
    public string? GhiChuHoaDon { get; private set; }
    public string? LoaiHoaDon { get; private set; }
    public bool IsTachPhieu { get; private set; } = false;
    public string? SaCare { get; private set; }
    public string? SrCare { get; private set; }
    public decimal SoTienDaDeNghiThanhToan { get; private set; } = decimal.Zero;
    public decimal TyGiaUsdRmb { get; private set; } = decimal.Zero;
    public decimal TiGiaRmbVanChuyen { get; private set; } = decimal.Zero;
    public decimal ChiPhiSoVoiInvoice { get; private set; } = decimal.Zero;
    public string? MaNhaCungCapNuocNgoai { get; private set; }
    public decimal PhiBank { get; private set; } = decimal.Zero;
    public decimal PhiThongQuan { get; private set; } = decimal.Zero;
    public decimal PhiXangDau { get; private set; } = decimal.Zero;
    public bool CanDiLayHang { get; private set; } = false;
    public string? MaVanDonLayHang { get; private set; }
    public string? SoBill { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public IReadOnlyCollection<NhapKhoChiTiet> NhapKhoChiTiets => _nhapKhoChiTiets.AsReadOnly();


}
