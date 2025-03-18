using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.Sales.KhachHang.DanhGiaKhachHang;

public sealed class DanhGiaKhachHang : AggregateRoot, ISoftDelete
{

    private DanhGiaKhachHang()
    {
    }

    public DanhGiaKhachHang(
        string? nganhNghe,
        int namThanhLap,
        int soLuongNhanVien,
        string? nguoiQuyetDinhMuaHang,
        string? sanPhamQuanTam,
        string? hangQuanTam,
        bool? coNhaXuong,
        int sanLuongSanXuat,
        string? doiThuCanhTranh,
        string? coHoiPhatTrien,
        string? hopDongDaKy,
        Ulid? idCTKMThamGia,
        string? duAnTiemNangSapToi,
        string? tinhHinhTaiChinh,
        string? luuY,
        Ulid idKhachHang)
    {
        Id = Ulid.NewUlid();
        IdKhachHang = idKhachHang;
        NganhNghe = nganhNghe;
        NamThanhLap = namThanhLap;
        SoLuongNhanVien = soLuongNhanVien;
        NguoiQuyetDinhMuaHang = nguoiQuyetDinhMuaHang;
        SanPhamQuanTam = sanPhamQuanTam;
        HangQuanTam = hangQuanTam;
        CoNhaXuong = coNhaXuong;
        SanLuongSanXuat = sanLuongSanXuat;
        DoiThuCanhTranh = doiThuCanhTranh;
        CoHoiPhatTrien = coHoiPhatTrien;
        HopDongDaKy = hopDongDaKy;
        IdCTKMThamGia = idCTKMThamGia;
        DuAnTiemNangSapToi = duAnTiemNangSapToi;
        TinhHinhTaiChinh = tinhHinhTaiChinh;
        LuuY = luuY;
    }

    public string? NganhNghe { get; private set; }

    public int NamThanhLap { get; private set; }

    public int SoLuongNhanVien { get; private set; }

    public string? NguoiQuyetDinhMuaHang { get; private set; }

    public string? SanPhamQuanTam { get; private set; }

    public string? HangQuanTam { get; private set; }

    public bool? CoNhaXuong { get; private set; }

    public int SanLuongSanXuat { get; private set; }

    public string? DoiThuCanhTranh { get; private set; }

    public string? CoHoiPhatTrien { get; private set; }

    public string? HopDongDaKy { get; private set; }

    public Ulid? IdCTKMThamGia { get; private set; }

    public string? DuAnTiemNangSapToi { get; private set; }

    public string? TinhHinhTaiChinh { get; private set; }

    public string? LuuY { get; private set; }

    public Ulid IdKhachHang { get; private set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    public KhachHang KhachHang { get; set; }

    public static DanhGiaKhachHang Create(
        string? nganhNghe,
        int namThanhLap,
        int soLuongNhanVien,
        string? nguoiQuyetDinhMuaHang,
        string? sanPhamQuanTam,
        string? hangQuanTam,
        bool? coNhaXuong,
        int sanLuongSanXuat,
        string? doiThuCanhTranh,
        string? coHoiPhatTrien,
        string? hopDongDaKy,
        Ulid? idCTKMThamGia,
        string? duAnTiemNangSapToi,
        string? tinhHinhTaiChinh,
        string? luuY,
        Ulid idKhachHang)
    {
        return new DanhGiaKhachHang(
            nganhNghe,
            namThanhLap,
            soLuongNhanVien,
            nguoiQuyetDinhMuaHang,
            sanPhamQuanTam,
            hangQuanTam,
            coNhaXuong,
            sanLuongSanXuat,
            doiThuCanhTranh,
            coHoiPhatTrien,
            hopDongDaKy,
            idCTKMThamGia,
            duAnTiemNangSapToi,
            tinhHinhTaiChinh,
            luuY,
            idKhachHang);
    }

    public void Update(
        string? nganhNghe = null,
        int? namThanhLap = null,
        int? soLuongNhanVien = null,
        string? nguoiQuyetDinhMuaHang = null,
        string? sanPhamQuanTam = null,
        string? hangQuanTam = null,
        bool? coNhaXuong = null,
        int? sanLuongSanXuat = null,
        string? doiThuCanhTranh = null,
        string? coHoiPhatTrien = null,
        string? hopDongDaKy = null,
        Ulid? idCTKMThamGia = null,
        string? duAnTiemNangSapToi = null,
        string? tinhHinhTaiChinh = null,
        string? luuY = null)
    {
        NganhNghe = nganhNghe ?? NganhNghe;
        NamThanhLap = namThanhLap ?? NamThanhLap;
        SoLuongNhanVien = soLuongNhanVien ?? SoLuongNhanVien;
        NguoiQuyetDinhMuaHang = nguoiQuyetDinhMuaHang ?? NguoiQuyetDinhMuaHang;
        SanPhamQuanTam = sanPhamQuanTam ?? SanPhamQuanTam;
        HangQuanTam = hangQuanTam ?? HangQuanTam;
        CoNhaXuong = coNhaXuong ?? CoNhaXuong;
        SanLuongSanXuat = sanLuongSanXuat ?? SanLuongSanXuat;
        DoiThuCanhTranh = doiThuCanhTranh ?? DoiThuCanhTranh;
        CoHoiPhatTrien = coHoiPhatTrien ?? CoHoiPhatTrien;
        HopDongDaKy = hopDongDaKy ?? HopDongDaKy;
        IdCTKMThamGia = idCTKMThamGia ?? IdCTKMThamGia;
        DuAnTiemNangSapToi = duAnTiemNangSapToi ?? DuAnTiemNangSapToi;
        TinhHinhTaiChinh = tinhHinhTaiChinh ?? TinhHinhTaiChinh;
        LuuY = luuY ?? LuuY;
    }
}
