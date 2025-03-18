using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Share.Extensions;

namespace ERP.Domain.Entities.Sales.BaoGias.BaoGia;


public sealed class BaoGia : AggregateRoot, ISoftDelete
{

    private readonly List<BaoGiaChiTiet.BaoGiaChiTiet> _baoGiaChiTiets;
    private readonly List<BaoGiaComment> _baoGiaComments;
    private readonly List<LyDoTruot.LyDoTruot> _lyDoTruots;



    private BaoGia()
    {
        _baoGiaChiTiets = [];
    }

    public BaoGia(
    string soBaoGia,
    DateTime ngayBaoGia,
    Ulid idKhachHang,
    Ulid idLienHe,
    int hieuLucBaoGia,
    Ulid idDieuKhoanThanhToan,
    Ulid idDieuKhoanThanhToanKhachHang,
    decimal thanhTienNet,
    ThanhTien thanhTien0,
    ThanhTien thanhTien8,
    ThanhTien thanhTien10,
    decimal tongThanhTien,
    decimal tienThuDichVuVat,
    LoaiDon loaiDon,
    TrangThaiDon trangThaiDon,
    string? lyDoTruot,
    DateOnly? ngayTruot,
    TrangThaiDuyet trangThaiDuyet,
    string? lyDoHuyDuyet,
    KhaNangTrung khaNangTrung,
    bool isBaoGiaQuanTrong,
    string? sr,
    string? sr2,
    string? sa,
    Ulid? idCTKM,
    string? chiNhanh,
    string? khoXuLy,
    string? diaChiGiaoHang,
    string? nguoiNhanHang,
    DateOnly? ngayDuKienGiao,
    int soLuongComment,
    DuyetCMDuoi20 duyetCMDuoi20,
    string? iasHoTro1,
    string? iasHoTro2,
    bool isDeleted,
    DateTime? ngayXoa)
    {
        Id = Ulid.NewUlid();
        SoBaoGia = soBaoGia;
        NgayBaoGia = ngayBaoGia;
        IdKhachHang = idKhachHang;
        IdLienHe = idLienHe;
        HieuLucBaoGia = hieuLucBaoGia;
        IdDieuKhoanThanhToan = idDieuKhoanThanhToan;
        IdDieuKhoanThanhToanKhachHang = idDieuKhoanThanhToanKhachHang;
        ThanhTienNet = thanhTienNet;
        ThanhTien0 = thanhTien0;
        ThanhTien8 = thanhTien8;
        ThanhTien10 = thanhTien10;
        TongThanhTien = tongThanhTien;
        TienThuDichVuVat = tienThuDichVuVat;
        LoaiDon = loaiDon;
        TrangThaiDon = trangThaiDon;
        LyDoTruot = lyDoTruot;
        NgayTruot = ngayTruot;
        TrangThaiDuyet = trangThaiDuyet;
        LyDoHuyDuyet = lyDoHuyDuyet;
        KhaNangTrung = khaNangTrung;
        IsBaoGiaQuanTrong = isBaoGiaQuanTrong;
        SR = sr;
        SR2 = sr2;
        SA = sa;
        IdCTKM = idCTKM;
        ChiNhanh = chiNhanh;
        KhoXuLy = khoXuLy;
        DiaChiGiaoHang = diaChiGiaoHang;
        NguoiNhanHang = nguoiNhanHang;
        NgayDuKienGiao = ngayDuKienGiao;
        SoLuongComment = soLuongComment;
        DuyetCMDuoi20 = duyetCMDuoi20;
        IASHoTro1 = iasHoTro1;
        IASHoTro2 = iasHoTro2;
        IsDeleted = isDeleted;
        NgayXoa = ngayXoa;
    }

    public string SoBaoGia { get; private set; }

    public DateTime NgayBaoGia { get; private set; }

    public Ulid IdKhachHang { get; private set; }

    public Ulid IdLienHe { get; private set; }

    public int HieuLucBaoGia { get; private set; }

    public Ulid IdDieuKhoanThanhToan { get; private set; }

    public Ulid IdDieuKhoanThanhToanKhachHang { get; private set; }

    public decimal ThanhTienNet { get; private set; }

    public ThanhTien ThanhTien0 { get; private set; }

    public ThanhTien ThanhTien8 { get; private set; }

    public ThanhTien ThanhTien10 { get; private set; }

    public decimal TongThanhTien { get; private set; }

    public decimal TienThuDichVuVat { get; private set; }

    public LoaiDon LoaiDon { get; private set; }

    public TrangThaiDon TrangThaiDon { get; private set; }

    public string? LyDoTruot { get; private set; }

    public DateOnly? NgayTruot { get; private set; }

    public TrangThaiDuyet TrangThaiDuyet { get; private set; }

    public string? LyDoHuyDuyet { get; private set; }

    public KhaNangTrung KhaNangTrung { get; private set; }

    public bool IsBaoGiaQuanTrong { get; private set; }

    public string? SR { get; private set; }

    public string? SR2 { get; private set; }

    public string? SA { get; private set; }

    public Ulid? IdCTKM { get; private set; }

    public string? ChiNhanh { get; private set; }

    public string? KhoXuLy { get; private set; }

    public string? DiaChiGiaoHang { get; private set; }

    public string? NguoiNhanHang { get; private set; }

    public DateOnly? NgayDuKienGiao { get; private set; }

    public int SoLuongComment { get; private set; }

    public DuyetCMDuoi20 DuyetCMDuoi20 { get; private set; }

    public string? IASHoTro1 { get; private set; }

    public string? IASHoTro2 { get; private set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    public ICollection<BaoGiaChiTiet.BaoGiaChiTiet> BaoGiaChiTiets => _baoGiaChiTiets.AsReadOnly();

    public ICollection<BaoGias.BaoGiaComment> BaoGiaComments => _baoGiaComments.AsReadOnly();

    public ICollection<LyDoTruot.LyDoTruot> LyDoTruots => _lyDoTruots.AsReadOnly();

    public static BaoGia Create(
    string sobaoGia,
    DateTime ngayBaoGia,
    Ulid idKhachHang,
    Ulid idLienHe,
    int hieuLucBaoGia,
    Ulid idDieuKhoanThanhToan,
    Ulid idDieuKhoanThanhToanKhachHang,
    decimal thanhTienNet,
    ThanhTien thanhTien0,
    ThanhTien thanhTien8,
    ThanhTien thanhTien10,
    decimal tongThanhTien,
    decimal tienThuDichVuVat,
    LoaiDon loaiDon,
    TrangThaiDon trangThaiDon,
    string? lyDoTruot,
    DateOnly? ngayTruot,
    TrangThaiDuyet trangThaiDuyet,
    string? lyDoHuyDuyet,
    KhaNangTrung khaNangTrung,
    bool isBaoGiaQuanTrong,
    string? sr,
    string? sr2,
    string? sa,
    Ulid? idCTKM,
    string? chiNhanh,
    string? khoXuLy,
    string? diaChiGiaoHang,
    string? nguoiNhanHang,
    DateOnly? ngayDuKienGiao,
    int soLuongComment,
    DuyetCMDuoi20 duyetCMDuoi20,
    string? iashHoTro1,
    string? iashHoTro2)
    {
        return new BaoGia
        {
            Id = Ulid.NewUlid(),
            SoBaoGia = sobaoGia,
            NgayBaoGia = ngayBaoGia,
            IdKhachHang = idKhachHang,
            IdLienHe = idLienHe,
            HieuLucBaoGia = hieuLucBaoGia,
            IdDieuKhoanThanhToan = idDieuKhoanThanhToan,
            IdDieuKhoanThanhToanKhachHang = idDieuKhoanThanhToanKhachHang,
            ThanhTienNet = thanhTienNet,
            ThanhTien0 = thanhTien0,
            ThanhTien8 = thanhTien8,
            ThanhTien10 = thanhTien10,
            TongThanhTien = tongThanhTien,
            TienThuDichVuVat = tienThuDichVuVat,
            LoaiDon = loaiDon,
            TrangThaiDon = trangThaiDon,
            LyDoTruot = lyDoTruot,
            NgayTruot = ngayTruot,
            TrangThaiDuyet = trangThaiDuyet,
            LyDoHuyDuyet = lyDoHuyDuyet,
            KhaNangTrung = khaNangTrung,
            IsBaoGiaQuanTrong = isBaoGiaQuanTrong,
            SR = sr,
            SR2 = sr2,
            SA = sa,
            IdCTKM = idCTKM,
            ChiNhanh = chiNhanh,
            KhoXuLy = khoXuLy,
            DiaChiGiaoHang = diaChiGiaoHang,
            NguoiNhanHang = nguoiNhanHang,
            NgayDuKienGiao = ngayDuKienGiao,
            SoLuongComment = soLuongComment,
            DuyetCMDuoi20 = duyetCMDuoi20,
            IASHoTro1 = iashHoTro1,
            IASHoTro2 = iashHoTro2
        };
    }

    public void Update(
    DateTime? ngayBaoGia,
    Ulid? idKhachHang,
    Ulid? idLienHe,
    int? hieuLucBaoGia,
    Ulid? idDieuKhoanThanhToan,
    Ulid? idDieuKhoanThanhToanKhachHang,
    decimal? thanhTienNet,
    ThanhTien? thanhTien0,
    ThanhTien? thanhTien8,
    ThanhTien? thanhTien10,
    decimal? tongThanhTien,
    decimal? tienThuDichVuVat,
    string? loaiDon,
    string? trangThaiDon,
    string? lyDoTruot,
    DateOnly? ngayTruot,
    string? trangThaiDuyet,
    string? lyDoHuyDuyet,
    string? khaNangTrung,
    bool? isBaoGiaQuanTrong,
    string? sr,
    string? sr2,
    string? sa,
    Ulid? idCTKM,
    string? chiNhanh,
    string? khoXuLy,
    string? diaChiGiaoHang,
    string? nguoiNhanHang,
    DateOnly? ngayDuKienGiao,
    int? soLuongComment,
    bool? CanDuyetCMDuoi20,
    string? NguoiDuyetCMDuoi20,
    string? NgayDuyetCMDuoi20,
    string? GhiChuDuyetCMDuoi20,
    string? iashHoTro1,
    string? iashHoTro2)
    {
        var duyetCMDuoi201 = DuyetCMDuoi20.Create(
            CanDuyetCMDuoi20 != null ? (bool)CanDuyetCMDuoi20 : DuyetCMDuoi20.CanDuyetCMDuoi20,
            NguoiDuyetCMDuoi20 ?? DuyetCMDuoi20.NguoiDuyetCMDuoi20,
            NgayDuyetCMDuoi20 != null ? NgayDuyetCMDuoi20.ConvertToDateOnly() : DuyetCMDuoi20.NgayDuyetCMDuoi20,
            GhiChuDuyetCMDuoi20 ?? DuyetCMDuoi20.GhiChuDuyetCMDuoi20);

        NgayBaoGia = ngayBaoGia ?? NgayBaoGia;
        IdKhachHang = idKhachHang ?? IdKhachHang;
        IdLienHe = idLienHe ?? IdLienHe;
        HieuLucBaoGia = hieuLucBaoGia ?? HieuLucBaoGia;
        IdDieuKhoanThanhToan = idDieuKhoanThanhToan ?? IdDieuKhoanThanhToan;
        IdDieuKhoanThanhToanKhachHang = idDieuKhoanThanhToanKhachHang ?? IdDieuKhoanThanhToanKhachHang;
        ThanhTienNet = thanhTienNet ?? ThanhTienNet;
        ThanhTien0 = thanhTien0 ?? ThanhTien0;
        ThanhTien8 = thanhTien8 ?? ThanhTien8;
        ThanhTien10 = thanhTien10 ?? ThanhTien10;
        TongThanhTien = tongThanhTien ?? TongThanhTien;
        TienThuDichVuVat = tienThuDichVuVat ?? TienThuDichVuVat;
        LoaiDon = loaiDon != null ? LoaiDon.FromValue(loaiDon) : LoaiDon;
        TrangThaiDon = trangThaiDon != null ? TrangThaiDon.FromValue(trangThaiDon) : TrangThaiDon;
        LyDoTruot = !string.IsNullOrEmpty(lyDoTruot) ? lyDoTruot : LyDoTruot;
        NgayTruot = ngayTruot ?? NgayTruot;
        TrangThaiDuyet = trangThaiDuyet != null ? TrangThaiDuyet.FromValue(trangThaiDuyet) : TrangThaiDuyet;
        LyDoHuyDuyet = !string.IsNullOrEmpty(lyDoHuyDuyet) ? lyDoHuyDuyet : LyDoHuyDuyet;
        KhaNangTrung = khaNangTrung != null ? KhaNangTrung.FromValue(khaNangTrung) : KhaNangTrung;
        IsBaoGiaQuanTrong = isBaoGiaQuanTrong ?? IsBaoGiaQuanTrong;
        SR = !string.IsNullOrEmpty(sr) ? sr : SR;
        SR2 = !string.IsNullOrEmpty(sr2) ? sr2 : SR2;
        SA = !string.IsNullOrEmpty(sa) ? sa : SA;
        IdCTKM = idCTKM ?? IdCTKM;
        ChiNhanh = !string.IsNullOrEmpty(chiNhanh) ? chiNhanh : ChiNhanh;
        KhoXuLy = !string.IsNullOrEmpty(khoXuLy) ? khoXuLy : KhoXuLy;
        DiaChiGiaoHang = !string.IsNullOrEmpty(diaChiGiaoHang) ? diaChiGiaoHang : DiaChiGiaoHang;
        NguoiNhanHang = !string.IsNullOrEmpty(nguoiNhanHang) ? nguoiNhanHang : NguoiNhanHang;
        NgayDuKienGiao = ngayDuKienGiao ?? NgayDuKienGiao;
        SoLuongComment = soLuongComment ?? SoLuongComment;
        DuyetCMDuoi20 = duyetCMDuoi201;
        IASHoTro1 = !string.IsNullOrEmpty(iashHoTro1) ? iashHoTro1 : IASHoTro1;
        IASHoTro2 = !string.IsNullOrEmpty(iashHoTro2) ? iashHoTro2 : IASHoTro2;
    }

    public void AddBaoGiaChiTiet(ICollection<BaoGiaChiTiet.BaoGiaChiTiet> baoGiaChiTiet)
    {
        _baoGiaChiTiets.AddRange(baoGiaChiTiet);
    }

    public void UpdateBaoGiaChiTiet(ICollection<BaoGiaChiTiet.BaoGiaChiTiet> updateBaoGiaChiTiets)
    {
        var missingIds = _baoGiaChiTiets.Where(ct => !updateBaoGiaChiTiets.Any(ud => ud.Id == ct.Id)).Select(ct => ct.Id).ToList();
        foreach (Ulid id in missingIds)
        {
            BaoGiaChiTiet.BaoGiaChiTiet? chitiet = _baoGiaChiTiets.Find(u => u.Id == id);
            if (chitiet != null)
            {
                _baoGiaChiTiets.Remove(chitiet);
            }
        }

        foreach (BaoGiaChiTiet.BaoGiaChiTiet updateBaoGiaChiTiet in updateBaoGiaChiTiets)
        {
            BaoGiaChiTiet.BaoGiaChiTiet? existingDetail = _baoGiaChiTiets.Find(d => d.Id == updateBaoGiaChiTiet.Id);
            if (existingDetail != null)
            {
                existingDetail.Update(
                    updateBaoGiaChiTiet.MaDieuChinh,
                    updateBaoGiaChiTiet.TenHang,
                    updateBaoGiaChiTiet.IdNhomHang,
                    updateBaoGiaChiTiet.ItemCode,
                    updateBaoGiaChiTiet.SoLuong,
                    updateBaoGiaChiTiet.DonViTinh,
                    updateBaoGiaChiTiet.BaoHanh,
                    updateBaoGiaChiTiet.DonGia,
                    updateBaoGiaChiTiet.ThanhTienNet,
                    updateBaoGiaChiTiet.ThanhTienHang,
                    updateBaoGiaChiTiet.ThueGTGT,
                    updateBaoGiaChiTiet.ThueDichVuVat,
                    updateBaoGiaChiTiet.TongThanhTien,
                    updateBaoGiaChiTiet.PhanTramCM,
                    updateBaoGiaChiTiet.ThueTNDN,
                    updateBaoGiaChiTiet.TienThueTNDN,
                    updateBaoGiaChiTiet.TienKhachNhan,
                    updateBaoGiaChiTiet.ThoiGianGiaoHang,
                    updateBaoGiaChiTiet.IdKhoXuLy,
                    updateBaoGiaChiTiet.GhiChu,
                    updateBaoGiaChiTiet.SoLuongTon,
                    updateBaoGiaChiTiet.HinhAnhMinhHoa,
                    updateBaoGiaChiTiet.Discontinue,
                    updateBaoGiaChiTiet.NoiDungYeuCauHoiHang,
                    updateBaoGiaChiTiet.MaXinGia,
                    updateBaoGiaChiTiet.TrangThaiDuyetGia,
                    updateBaoGiaChiTiet.GiaBanThucTe,
                    updateBaoGiaChiTiet.GiaGMinTinhThuong,
                    updateBaoGiaChiTiet.LaMaKhuyenMai,
                    updateBaoGiaChiTiet.LaMaLo);
            }
            else
            {
                _baoGiaChiTiets.Add(updateBaoGiaChiTiet);
            }
        }
    }
}
