using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.Sales.KhachHang;

public sealed class KhaiHaiQuan : AggregateRoot, ISoftDelete
{
    private KhaiHaiQuan()
    {
    }

    public KhaiHaiQuan(Ulid idKhachHang, string chiCucHaiQuan, string maDiaDiemLuuKhoHangChoThongQuanDuKien, string diaDiemDoHang, string diaDiemDichChoVanChuyenBaoThue, string? ghiChuLamHaiQuanMayDau, string? ghiChuChungTuNhapKhachHangCanCheck, string? thongTinLienHeKhachHang, string? boChungTuBanCung, string? termOfSale, string? tenTiengAnh)
    {
        Id = Ulid.NewUlid();
        IdKhachHang = idKhachHang;
        ChiCucHaiQuan = chiCucHaiQuan;
        MaDiaDiemLuuKhoHangChoThongQuanDuKien = maDiaDiemLuuKhoHangChoThongQuanDuKien;
        DiaDiemDoHang = diaDiemDoHang;
        DiaDiemDichChoVanChuyenBaoThue = diaDiemDichChoVanChuyenBaoThue;
        GhiChuLamHaiQuanMayDau = ghiChuLamHaiQuanMayDau;
        GhiChuChungTuNhapKhachHangCanCheck = ghiChuChungTuNhapKhachHangCanCheck;
        ThongTinLienHeKhachHang = thongTinLienHeKhachHang;
        BoChungTuBanCung = boChungTuBanCung;
        TermOfSale = termOfSale;
        TenTiengAnh = tenTiengAnh;
    }

    public Ulid IdKhachHang { get; private set; }

    public string ChiCucHaiQuan { get; private set; }

    public string MaDiaDiemLuuKhoHangChoThongQuanDuKien { get; private set; }

    public string DiaDiemDoHang { get; private set; }

    public string DiaDiemDichChoVanChuyenBaoThue { get; private set; }

    public string? GhiChuLamHaiQuanMayDau { get; private set; }

    public string? GhiChuChungTuNhapKhachHangCanCheck { get; private set; }

    public string? ThongTinLienHeKhachHang { get; private set; }

    public string? BoChungTuBanCung { get; private set; }

    public string? TermOfSale { get; private set; }

    public string? TenTiengAnh { get; private set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    public KhachHang KhachHang { get; set; }

    public static KhaiHaiQuan Create(
        Ulid idKhachHang,
        string chiCucHaiQuan,
        string maDiaDiemLuuKhoHangChoThongQuanDuKien,
        string diaDiemDoHang,
        string diaDiemDichChoVanChuyenBaoThue,
        string? ghiChuLamHaiQuanMayDau,
        string? ghiChuChungTuNhapKhachHangCanCheck,
        string? thongTinLienHeKhachHang,
        string? boChungTuBanCung,
        string? termOfSale,
        string? tenTiengAnh)
    {
        return new KhaiHaiQuan(
            idKhachHang,
            chiCucHaiQuan,
            maDiaDiemLuuKhoHangChoThongQuanDuKien,
            diaDiemDoHang,
            diaDiemDichChoVanChuyenBaoThue,
            ghiChuLamHaiQuanMayDau,
            ghiChuChungTuNhapKhachHangCanCheck,
            thongTinLienHeKhachHang,
            boChungTuBanCung,
            termOfSale,
            tenTiengAnh);
    }

    // Update method
    public void Update(
        string? chiCucHaiQuan = null,
        string? maDiaDiemLuuKhoHangChoThongQuanDuKien = null,
        string? diaDiemDoHang = null,
        string? diaDiemDichChoVanChuyenBaoThue = null,
        string? ghiChuLamHaiQuanMayDau = null,
        string? ghiChuChungTuNhapKhachHangCanCheck = null,
        string? thongTinLienHeKhachHang = null,
        string? boChungTuBanCung = null,
        string? termOfSale = null,
        string? tenTiengAnh = null)
    {
        ChiCucHaiQuan = chiCucHaiQuan ?? ChiCucHaiQuan;
        MaDiaDiemLuuKhoHangChoThongQuanDuKien = maDiaDiemLuuKhoHangChoThongQuanDuKien ?? MaDiaDiemLuuKhoHangChoThongQuanDuKien;
        DiaDiemDoHang = diaDiemDoHang ?? DiaDiemDoHang;
        DiaDiemDichChoVanChuyenBaoThue = diaDiemDichChoVanChuyenBaoThue ?? DiaDiemDichChoVanChuyenBaoThue;
        GhiChuLamHaiQuanMayDau = ghiChuLamHaiQuanMayDau ?? GhiChuLamHaiQuanMayDau;
        GhiChuChungTuNhapKhachHangCanCheck = ghiChuChungTuNhapKhachHangCanCheck ?? GhiChuChungTuNhapKhachHangCanCheck;
        ThongTinLienHeKhachHang = thongTinLienHeKhachHang ?? ThongTinLienHeKhachHang;
        BoChungTuBanCung = boChungTuBanCung ?? BoChungTuBanCung;
        TermOfSale = termOfSale ?? TermOfSale;
        TenTiengAnh = tenTiengAnh ?? TenTiengAnh;
    }
}
