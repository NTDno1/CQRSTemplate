using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Sales.KhachHang.TaiKhoanNganHang;
using ERP.Share.Extensions;
namespace ERP.Domain.Entities.Sales.KhachHang;
public sealed class KhachHang : AggregateRoot, ISoftDelete
{

    private readonly List<TaiKhoanNganHangKhachHang> _taiKhoanNganHangKhachHangs;

    private readonly List<KhachHangLienHe> _khachHangLienHes;

    private readonly List<PhanHoiKhachHang.PhanHoiKhachHang> _phanHoiKhachHangs;

    private readonly List<DanhGiaKhachHang.DanhGiaKhachHang> _danhGiaKhachHangs;

    private readonly List<KhaiHaiQuan> _khaiHaiQuans;

    private KhachHang()
    {
        _taiKhoanNganHangKhachHangs = [];
        _khachHangLienHes = [];
        _phanHoiKhachHangs = [];
        _danhGiaKhachHangs = [];
        _khaiHaiQuans = [];
    }

    private KhachHang(
        Ulid id,
        string maKhachHang,
        Ulid? idKhachHangCha,
        ThongTinLienHe thongTinLienHe,
        string soNhaDuongPhoGiaoHang,
        string quanHuyenGiaoHang,
        string tinhThanhPhoGiaoHang,
        HoaDon hoaDonMacDinh,
        string ghiChuHoaDonMacDinh,
        Ulid idLoaiKhach,
        string nganhNghe,
        string khuCongNghiep,
        string nguonGocKhachHang,
        string? sR,
        string? sR_DangKy,
        string? sR2,
        string? sR2_DangKy,
        string? sA,
        string? sA_DangKy,
        string? quanLy,
        string bU,
        string? ghiChuKhachHang,
        string? hoSoThanhToan,
        Ulid idDieuKhoanThanhToan,
        Ulid idDieuKhoanThanhToanNoiBo,
        TinhTrangHoatDong tinhTrangHoatDong,
        string? nguoiDaiDien,
        string? chucVuNguoiDaiDien,
        string? cMNDNguoiDaiDien,
        bool? canHDNT,
        bool? daCoHDNT,
        bool? kyPO,
        int? danhGiaKhachHang,
        bool? ngungCapHang,
        string? ghiChuCongNo,
        bool? dongDau,
        InTheoMauMacDinh inTheoMauMacDinh,
        string? khoMacDinh,
        TemMacDinh temMacDinh,
        string? giayChungNhanDauTu,
        bool? canGiayChungNhanDauTu,
        DateOnly? ngayCapGiayChungNhanDauTu,
        bool? canYeuCauXacNhanCongNo,
        bool? hienGiaKhiInPhieuXuatKho,
        bool? dSE,
        VendorStatus vendorStatus,
        string? heThongKhachHang,
        string? mangKinhDoanh)
    {
        Id = id;
        MaKhachHang = maKhachHang;
        IdKhachHangCha = idKhachHangCha;
        ThongTinLienHe = thongTinLienHe;
        SoNhaDuongPhoGiaoHang = soNhaDuongPhoGiaoHang;
        QuanHuyenGiaoHang = quanHuyenGiaoHang;
        TinhThanhPhoGiaoHang = tinhThanhPhoGiaoHang;
        HoaDonMacDinh = hoaDonMacDinh;
        GhiChuHoaDonMacDinh = ghiChuHoaDonMacDinh;
        IdLoaiKhach = idLoaiKhach;
        NganhNghe = nganhNghe;
        KhuCongNghiep = khuCongNghiep;
        NguonGocKhachHang = nguonGocKhachHang;
        SR = sR;
        SR_DangKy = sR_DangKy;
        SR2 = sR2;
        SR2_DangKy = sR2_DangKy;
        SA = sA;
        SA_DangKy = sA_DangKy;
        QuanLy = quanLy;
        BU = bU;
        GhiChuKhachHang = ghiChuKhachHang;
        HoSoThanhToan = hoSoThanhToan;
        IdDieuKhoanThanhToan = idDieuKhoanThanhToan;
        IdDieuKhoanThanhToanNoiBo = idDieuKhoanThanhToanNoiBo;
        TinhTrangHoatDong = tinhTrangHoatDong;
        NguoiDaiDien = nguoiDaiDien;
        ChucVuNguoiDaiDien = chucVuNguoiDaiDien;
        CMNDNguoiDaiDien = cMNDNguoiDaiDien;
        CanHDNT = canHDNT;
        DaCoHDNT = daCoHDNT;
        KyPO = kyPO;
        DanhGiaKhachHang = danhGiaKhachHang;
        NgungCapHang = ngungCapHang;
        GhiChuCongNo = ghiChuCongNo;
        DongDau = dongDau;
        InTheoMauMacDinh = inTheoMauMacDinh;
        KhoMacDinh = khoMacDinh;
        TemMacDinh = temMacDinh;
        GiayChungNhanDauTu = giayChungNhanDauTu;
        CanGiayChungNhanDauTu = canGiayChungNhanDauTu;
        NgayCapGiayChungNhanDauTu = ngayCapGiayChungNhanDauTu;
        CanYeuCauXacNhanCongNo = canYeuCauXacNhanCongNo;
        HienGiaKhiInPhieuXuatKho = hienGiaKhiInPhieuXuatKho;
        DSE = dSE;
        VendorStatus = vendorStatus;
        HeThongKhachHang = heThongKhachHang;
        MangKinhDoanh = mangKinhDoanh;
        _taiKhoanNganHangKhachHangs = new List<TaiKhoanNganHangKhachHang>();
        _khachHangLienHes = new List<KhachHangLienHe>();
        _phanHoiKhachHangs = new List<PhanHoiKhachHang.PhanHoiKhachHang>();
        _danhGiaKhachHangs = new List<DanhGiaKhachHang.DanhGiaKhachHang>();
        _khaiHaiQuans = new List<KhaiHaiQuan>();
    }

    public Ulid? IdKhachHangCha { get; private set; }

    public string? MaKhachHang { get; private set; }

    public ThongTinLienHe ThongTinLienHe { get; private set; }

    public string SoNhaDuongPhoGiaoHang { get; private set; }

    public string QuanHuyenGiaoHang { get; private set; }

    public string TinhThanhPhoGiaoHang { get; private set; }

    public HoaDon HoaDonMacDinh { get; private set; }

    public string? GhiChuHoaDonMacDinh { get; private set; }

    public Ulid IdLoaiKhach { get; private set; }

    public string NganhNghe { get; private set; }

    public string KhuCongNghiep { get; private set; }

    public string NguonGocKhachHang { get; private set; }

    public string? SR { get; private set; }

    public string? SR_DangKy { get; private set; }

    public string? SR2 { get; private set; }

    public string? SR2_DangKy { get; private set; }

    public string? SA { get; private set; }

    public string? SA_DangKy { get; private set; }

    public string? QuanLy { get; private set; }

    public string BU { get; private set; }

    public string? GhiChuKhachHang { get; private set; }

    public string? HoSoThanhToan { get; private set; }

    public Ulid IdDieuKhoanThanhToan { get; private set; }

    public Ulid IdDieuKhoanThanhToanNoiBo { get; private set; }

    public TinhTrangHoatDong TinhTrangHoatDong { get; private set; }

    public string? NguoiDaiDien { get; private set; }

    public string? ChucVuNguoiDaiDien { get; private set; }

    public string? CMNDNguoiDaiDien { get; private set; }

    public bool? CanHDNT { get; private set; }

    public bool? DaCoHDNT { get; private set; }

    public bool? KyPO { get; private set; }

    public int? DanhGiaKhachHang { get; private set; }

    public bool? NgungCapHang { get; private set; }

    public string? GhiChuCongNo { get; private set; }

    public bool? DongDau { get; private set; }

    public InTheoMauMacDinh InTheoMauMacDinh { get; private set; }

    public string? KhoMacDinh { get; private set; }

    public TemMacDinh TemMacDinh { get; private set; }

    public string? GiayChungNhanDauTu { get; private set; }

    public bool? CanGiayChungNhanDauTu { get; private set; }

    public DateOnly? NgayCapGiayChungNhanDauTu { get; private set; }

    public bool? CanYeuCauXacNhanCongNo { get; private set; }

    public bool? HienGiaKhiInPhieuXuatKho { get; private set; }

    public bool? DSE { get; private set; }

    public VendorStatus VendorStatus { get; private set; }

    public string? HeThongKhachHang { get; private set; }

    public string? MangKinhDoanh { get; private set; }

    public bool IsDeleted { get; set; }

    public DateTime? NgayXoa { get; set; }

    public KhachHang? KhachHangCha { get; set; }

    public ICollection<TaiKhoanNganHangKhachHang> TaiKhoanNganHangKhachHangs => _taiKhoanNganHangKhachHangs.AsReadOnly();

    public ICollection<KhachHangLienHe> KhachHangLienHes => _khachHangLienHes.AsReadOnly();

    public ICollection<PhanHoiKhachHang.PhanHoiKhachHang> PhanHoiKhachHangs => _phanHoiKhachHangs.AsReadOnly();

    public ICollection<DanhGiaKhachHang.DanhGiaKhachHang> DanhGiaKhachHangs => _danhGiaKhachHangs.AsReadOnly();

    public ICollection<KhaiHaiQuan> KhaiHaiQuans => _khaiHaiQuans.AsReadOnly();

    public static KhachHang Create(
        Ulid id,
        string maKhachHang,
        Ulid? idKhachHangCha,
        ThongTinLienHe thongTinLienHe,
        string soNhaDuongPhoGiaoHang,
        string quanHuyenGiaoHang,
        string tinhThanhPhoGiaoHang,
        HoaDon hoaDonMacDinh,
        string ghiChuHoaDonMacDinh,
        Ulid idLoaiKhach,
        string nganhNghe,
        string khuCongNghiep,
        string nguonGocKhachHang,
        string? sR,
        string? sR_DangKy,
        string? sR2,
        string? sR2_DangKy,
        string? sA,
        string? sA_DangKy,
        string? quanLy,
        string bU,
        string? ghiChuKhachHang,
        string? hoSoThanhToan,
        Ulid idDieuKhoanThanhToan,
        Ulid idDieuKhoanThanhToanNoiBo,
        TinhTrangHoatDong tinhTrangHoatDong,
        string? nguoiDaiDien,
        string? chucVuNguoiDaiDien,
        string? cMNDNguoiDaiDien,
        bool? canHDNT,
        bool? daCoHDNT,
        bool? kyPO,
        int? danhGiaKhachHang,
        bool? ngungCapHang,
        string? ghiChuCongNo,
        bool? dongDau,
        InTheoMauMacDinh inTheoMauMacDinh,
        string? khoMacDinh,
        TemMacDinh temMacDinh,
        string? giayChungNhanDauTu,
        bool? canGiayChungNhanDauTu,
        DateOnly? ngayCapGiayChungNhanDauTu,
        bool? canYeuCauXacNhanCongNo,
        bool? hienGiaKhiInPhieuXuatKho,
        bool? dSE,
        VendorStatus vendorStatus,
        string? heThongKhachHang,
        string? mangKinhDoanh,
        TaiKhoanNganHangKhachHang taiKhoanNganHangKhachHang,
        KhachHangLienHe khachHangLienHe)
    {
        var kh = new KhachHang(
            id,
            maKhachHang,
            idKhachHangCha,
            thongTinLienHe,
            soNhaDuongPhoGiaoHang,
            quanHuyenGiaoHang,
            tinhThanhPhoGiaoHang,
            hoaDonMacDinh,
            ghiChuHoaDonMacDinh,
            idLoaiKhach,
            nganhNghe,
            khuCongNghiep,
            nguonGocKhachHang,
            sR,
            sR_DangKy,
            sR2,
            sR2_DangKy,
            sA,
            sA_DangKy,
            quanLy,
            bU,
            ghiChuKhachHang,
            hoSoThanhToan,
            idDieuKhoanThanhToan,
            idDieuKhoanThanhToanNoiBo,
            tinhTrangHoatDong,
            nguoiDaiDien,
            chucVuNguoiDaiDien,
            cMNDNguoiDaiDien,
            canHDNT,
            daCoHDNT,
            kyPO,
            danhGiaKhachHang,
            ngungCapHang,
            ghiChuCongNo,
            dongDau,
            inTheoMauMacDinh,
            khoMacDinh,
            temMacDinh,
            giayChungNhanDauTu,
            canGiayChungNhanDauTu,
            ngayCapGiayChungNhanDauTu,
            canYeuCauXacNhanCongNo,
            hienGiaKhiInPhieuXuatKho,
            dSE,
            vendorStatus,
            heThongKhachHang,
            mangKinhDoanh);
        kh._taiKhoanNganHangKhachHangs.Add(taiKhoanNganHangKhachHang);
        kh._khachHangLienHes.Add(khachHangLienHe);
        return kh;
    }

    public void Update(
        string? tenCongTy,
        string? diaChiVanPhong,
        string? diaChiXuatHoaDon,
        string? emailNhanHoaDon,
        string? soDienThoai,
        string? maSoThue,
        string? website,
        string? soNhaDuongPhoGiaoHang,
        string? quanHuyenGiaoHang,
        string? tinhThanhPhoGiaoHang,
        string? hoaDonMacDinh,
        string? ghiChuHoaDonMacDinh,
        Ulid? idLoaiKhach,
        string? nganhNghe,
        string? khuCongNghiep,
        string? nguonGocKhachHang,
        string? sR,
        string? sR_DangKy,
        string? sR2,
        string? sR2_DangKy,
        string? sA,
        string? sA_DangKy,
        string? quanLy,
        string? bU,
        string? ghiChuKhachHang,
        string? hoSoThanhToan,
        Ulid? idDieuKhoanThanhToan,
        Ulid? idDieuKhoanThanhToanNoiBo,
        string? tinhTrangHoatDong,
        string? nguoiDaiDien,
        string? chucVuNguoiDaiDien,
        string? cMNDNguoiDaiDien,
        bool? canHDNT,
        bool? daCoHDNT,
        bool? kyPO,
        int? danhGiaKhachHang,
        bool? ngungCapHang,
        string? ghiChuCongNo,
        bool? dongDau,
        string? inTheoMauMacDinh,
        string? khoMacDinh,
        string? temMacDinh,
        string? giayChungNhanDauTu,
        bool? canGiayChungNhanDauTu,
        string? ngayCapGiayChungNhanDauTu,
        bool? canYeuCauXacNhanCongNo,
        bool? hienGiaKhiInPhieuXuatKho,
        bool? dSE,
        string? vendorStatus,
        string? heThongKhachHang,
        string? mangKinhDoanh)
    {
        string tenCongTys = tenCongTy ?? ThongTinLienHe.TenCongTy;
        string diaChiVanPhong1 = diaChiVanPhong ?? ThongTinLienHe.DiaChiVanPhong;
        string diaChiXuatHoaDon1 = diaChiXuatHoaDon ?? ThongTinLienHe.DiaChiXuatHoaDon;
        string emailNhanHoaDon1 = emailNhanHoaDon ?? ThongTinLienHe.EmailNhanHoaDon;
        string soDienThoai1 = soDienThoai ?? ThongTinLienHe.SoDienThoai;
        string maSoThue1 = maSoThue ?? ThongTinLienHe.MaSoThue;
        string website1 = website ?? ThongTinLienHe.Website;
        ThongTinLienHe = ThongTinLienHe.Create(tenCongTys, diaChiVanPhong1, diaChiXuatHoaDon1, emailNhanHoaDon1, soDienThoai1, maSoThue1, website1);
        SoNhaDuongPhoGiaoHang = !string.IsNullOrEmpty(soNhaDuongPhoGiaoHang) ? soNhaDuongPhoGiaoHang : SoNhaDuongPhoGiaoHang;
        QuanHuyenGiaoHang = !string.IsNullOrEmpty(quanHuyenGiaoHang) ? quanHuyenGiaoHang : QuanHuyenGiaoHang;
        TinhThanhPhoGiaoHang = !string.IsNullOrEmpty(tinhThanhPhoGiaoHang) ? tinhThanhPhoGiaoHang : TinhThanhPhoGiaoHang;
        HoaDonMacDinh = hoaDonMacDinh == null ? HoaDonMacDinh : HoaDon.FromValue(hoaDonMacDinh);
        GhiChuHoaDonMacDinh = !string.IsNullOrEmpty(ghiChuHoaDonMacDinh) ? ghiChuHoaDonMacDinh : GhiChuHoaDonMacDinh;
        IdLoaiKhach = idLoaiKhach ?? IdLoaiKhach;
        NganhNghe = !string.IsNullOrEmpty(nganhNghe) ? nganhNghe : NganhNghe;
        KhuCongNghiep = !string.IsNullOrEmpty(khuCongNghiep) ? khuCongNghiep : KhuCongNghiep;
        NguonGocKhachHang = !string.IsNullOrEmpty(nguonGocKhachHang) ? nguonGocKhachHang : NguonGocKhachHang;
        SR = !string.IsNullOrEmpty(sR) ? sR : SR;
        SR_DangKy = !string.IsNullOrEmpty(sR_DangKy) ? sR_DangKy : SR_DangKy;
        SR2 = !string.IsNullOrEmpty(sR2) ? sR2 : SR2;
        SR2_DangKy = !string.IsNullOrEmpty(sR2_DangKy) ? sR2_DangKy : SR2_DangKy;
        SA = !string.IsNullOrEmpty(sA) ? sA : SA;
        SA_DangKy = !string.IsNullOrEmpty(sA_DangKy) ? sA_DangKy : SA_DangKy;
        QuanLy = !string.IsNullOrEmpty(quanLy) ? quanLy : QuanLy;
        BU = !string.IsNullOrEmpty(bU) ? bU : BU;
        GhiChuKhachHang = !string.IsNullOrEmpty(ghiChuKhachHang) ? ghiChuKhachHang : GhiChuKhachHang;
        HoSoThanhToan = !string.IsNullOrEmpty(hoSoThanhToan) ? hoSoThanhToan : HoSoThanhToan;
        IdDieuKhoanThanhToan = idDieuKhoanThanhToan ?? IdDieuKhoanThanhToan;
        IdDieuKhoanThanhToanNoiBo = idDieuKhoanThanhToanNoiBo ?? IdDieuKhoanThanhToanNoiBo;
        TinhTrangHoatDong = tinhTrangHoatDong == null ? TinhTrangHoatDong : TinhTrangHoatDong.FromValue(tinhTrangHoatDong);
        NguoiDaiDien = !string.IsNullOrEmpty(nguoiDaiDien) ? nguoiDaiDien : NguoiDaiDien;
        ChucVuNguoiDaiDien = !string.IsNullOrEmpty(chucVuNguoiDaiDien) ? chucVuNguoiDaiDien : ChucVuNguoiDaiDien;
        CMNDNguoiDaiDien = !string.IsNullOrEmpty(cMNDNguoiDaiDien) ? cMNDNguoiDaiDien : CMNDNguoiDaiDien;
        CanHDNT = canHDNT ?? CanHDNT;
        DaCoHDNT = daCoHDNT ?? DaCoHDNT;
        KyPO = kyPO ?? KyPO;
        DanhGiaKhachHang = danhGiaKhachHang ?? DanhGiaKhachHang;
        NgungCapHang = ngungCapHang ?? NgungCapHang;
        GhiChuCongNo = !string.IsNullOrEmpty(ghiChuCongNo) ? ghiChuCongNo : GhiChuCongNo;
        DongDau = dongDau ?? DongDau;
        InTheoMauMacDinh = inTheoMauMacDinh == null ? InTheoMauMacDinh : InTheoMauMacDinh.FromValue(inTheoMauMacDinh);
        KhoMacDinh = !string.IsNullOrEmpty(khoMacDinh) ? khoMacDinh : KhoMacDinh;
        TemMacDinh = temMacDinh == null ? TemMacDinh : TemMacDinh.FromValue(temMacDinh);
        GiayChungNhanDauTu = !string.IsNullOrEmpty(giayChungNhanDauTu) ? giayChungNhanDauTu : GiayChungNhanDauTu;
        CanGiayChungNhanDauTu = canGiayChungNhanDauTu ?? CanGiayChungNhanDauTu;
        NgayCapGiayChungNhanDauTu = ngayCapGiayChungNhanDauTu == null ? NgayCapGiayChungNhanDauTu : ngayCapGiayChungNhanDauTu.ConvertToDateOnly();
        CanYeuCauXacNhanCongNo = canYeuCauXacNhanCongNo ?? CanYeuCauXacNhanCongNo;
        HienGiaKhiInPhieuXuatKho = hienGiaKhiInPhieuXuatKho ?? HienGiaKhiInPhieuXuatKho;
        DSE = dSE ?? DSE;
        VendorStatus = vendorStatus == null ? VendorStatus : VendorStatus.FromValue(vendorStatus);
        HeThongKhachHang = !string.IsNullOrEmpty(heThongKhachHang) ? heThongKhachHang : HeThongKhachHang;
        MangKinhDoanh = !string.IsNullOrEmpty(mangKinhDoanh) ? mangKinhDoanh : MangKinhDoanh;
    }

    public void UpdateTaiKhoanNganHang(
        Ulid? id,
        string? soTaiKhoan,
        string? loaiTaiKhoan,
        string? tenTaiKhoan,
        string? nganHang,
        string? chiNhanh,
        string? tinhThanhPho,
        string? hinhThucThanhToan)
    {
        if (id != null)
        {
            TaiKhoanNganHangKhachHang? existingDetail = _taiKhoanNganHangKhachHangs.Find(d => d.Id == id);

            if (existingDetail != null)
            {
                LoaiTaiKhoan getLoaiTaiKhoan = loaiTaiKhoan != null ? LoaiTaiKhoan.FromName(loaiTaiKhoan) : existingDetail.LoaiTaiKhoan;
                HinhThucThanhToan getHinhThucThanhToan = hinhThucThanhToan != null ? HinhThucThanhToan.FromValue(hinhThucThanhToan) : existingDetail.HinhThucThanhToan;
                existingDetail.Update(
                                soTaiKhoan,
                                getLoaiTaiKhoan,
                                tenTaiKhoan,
                                nganHang,
                                chiNhanh,
                                tinhThanhPho,
                                getHinhThucThanhToan);
            }
        }
    }

    public void UpdateKhachHangLienHe(
        Ulid? id,
        string tenLienHe,
        string vaiTro,
        string soDienThoai,
        string email,
        string tinhTrang,
        string ghiChu)
    {
        KhachHangLienHe? getKhachHangLienHe = _khachHangLienHes.Find(d => d.Id == id);
        getKhachHangLienHe?.Update(
              tenLienHe: tenLienHe,
              vaiTro: vaiTro,
              soDienThoai: soDienThoai,
              email: email,
              tinhTrang: tinhTrang != null ? TinhTrangKhachHangLienHe.FromValue(tinhTrang) : getKhachHangLienHe.TinhTrang,
              ghiChu: ghiChu);
    }

    public void UpdatePhanHoiKhachHang(IReadOnlyCollection<PhanHoiKhachHang.PhanHoiKhachHang> updatedDetails)
    {
        var missingItem = _phanHoiKhachHangs.Where(ct => !updatedDetails.Any(ud => ud.Id == ct.Id)).Select(ct => ct.Id).ToList();
        foreach (Ulid id in missingItem)
        {
            PhanHoiKhachHang.PhanHoiKhachHang? chitiet = _phanHoiKhachHangs.FirstOrDefault(u => u.Id == id);
            if (chitiet != null)
            {
                _phanHoiKhachHangs.Remove(chitiet);
            }
        }

        foreach (PhanHoiKhachHang.PhanHoiKhachHang updatedDetail in updatedDetails)
        {
            PhanHoiKhachHang.PhanHoiKhachHang? existingDetail = _phanHoiKhachHangs.Find(d => d.Id == updatedDetail.Id);
            if (existingDetail != null)
            {
                existingDetail.Update(
                    updatedDetail.NgayPhanHoi,
                    updatedDetail.IdUserPhanHoi,
                    updatedDetail.NoiDungPhanHoi,
                    updatedDetail.IdKhachHang,
                    updatedDetail.LoaiPhanHoi,
                    updatedDetail.CoGiaTri);
            }
            else
            {
                _phanHoiKhachHangs.Add(updatedDetail);
            }
        }
    }

    public void UpdateDanhGiaKhachHang(IReadOnlyCollection<DanhGiaKhachHang.DanhGiaKhachHang> updatedDetails)
    {
        var missingItem = _danhGiaKhachHangs.Where(ct => !updatedDetails.Any(ud => ud.Id == ct.Id)).Select(ct => ct.Id).ToList();
        foreach (Ulid id in missingItem)
        {
            DanhGiaKhachHang.DanhGiaKhachHang? chitiet = _danhGiaKhachHangs.Find(u => u.Id == id);
            if (chitiet != null)
            {
                _danhGiaKhachHangs.Remove(chitiet);
            }
        }

        foreach (DanhGiaKhachHang.DanhGiaKhachHang updatedDetail in updatedDetails)
        {
            DanhGiaKhachHang.DanhGiaKhachHang? existingDetail = _danhGiaKhachHangs.Find(d => d.Id == updatedDetail.Id);
            if (existingDetail != null)
            {
                existingDetail.Update(
                    updatedDetail.NganhNghe,
                    updatedDetail.NamThanhLap,
                    updatedDetail.SoLuongNhanVien,
                    updatedDetail.NguoiQuyetDinhMuaHang,
                    updatedDetail.SanPhamQuanTam,
                    updatedDetail.HangQuanTam,
                    updatedDetail.CoNhaXuong,
                    updatedDetail.SanLuongSanXuat,
                    updatedDetail.DoiThuCanhTranh,
                    updatedDetail.CoHoiPhatTrien,
                    updatedDetail.HopDongDaKy,
                    updatedDetail.IdCTKMThamGia,
                    updatedDetail.DuAnTiemNangSapToi,
                    updatedDetail.TinhHinhTaiChinh,
                    updatedDetail.LuuY);
            }
            else
            {
                _danhGiaKhachHangs.Add(updatedDetail);
            }
        }
    }

    public void UpdateKhaiHaiQuan(IReadOnlyCollection<KhaiHaiQuan> updatedDetails)
    {
        var missingItem = _khaiHaiQuans.Where(ct => !updatedDetails.Any(ud => ud.Id == ct.Id)).Select(ct => ct.Id).ToList();
        foreach (Ulid id in missingItem)
        {
            KhaiHaiQuan? chitiet = _khaiHaiQuans.Find(u => u.Id == id);
            if (chitiet != null)
            {
                _khaiHaiQuans.Remove(chitiet);
            }
        }

        foreach (KhaiHaiQuan updatedDetail in updatedDetails)
        {
            KhaiHaiQuan? existingDetail = _khaiHaiQuans.Find(d => d.Id == updatedDetail.Id);
            if (existingDetail != null)
            {
                existingDetail.Update(
                    updatedDetail.ChiCucHaiQuan,
                    updatedDetail.MaDiaDiemLuuKhoHangChoThongQuanDuKien,
                    updatedDetail.DiaDiemDoHang,
                    updatedDetail.DiaDiemDichChoVanChuyenBaoThue,
                    updatedDetail.GhiChuLamHaiQuanMayDau,
                    updatedDetail.GhiChuChungTuNhapKhachHangCanCheck,
                    updatedDetail.ThongTinLienHeKhachHang,
                    updatedDetail.BoChungTuBanCung,
                    updatedDetail.TermOfSale,
                    updatedDetail.TenTiengAnh);
            }
            else
            {
                _khaiHaiQuans.Add(updatedDetail);
            }
        }
    }

}
