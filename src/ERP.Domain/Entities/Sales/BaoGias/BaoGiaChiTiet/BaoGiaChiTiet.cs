using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Sales.BaoGias.BaoGia;

namespace ERP.Domain.Entities.Sales.BaoGias.BaoGiaChiTiet;

public sealed class BaoGiaChiTiet : AggregateRoot, ISoftDelete
{

    private BaoGiaChiTiet()
    {

    }

    public BaoGiaChiTiet(
    Ulid idBaoGia,
    Ulid idHangHoa,
    string? maDieuChinh,
    string? tenHang,
    Ulid? idNhomHang,
    string? itemCode,
    int soLuong,
    string donViTinh,
    int baoHanh,
    DonGia donGia,
    decimal? thanhTienNet,
    decimal? thanhTienHang,
    decimal? thueGTGT,
    decimal? thueDichVuVat,
    decimal? tongThanhTien,
    decimal? phanTramCM,
    decimal? thueTNDN,
    decimal? tienThueTNDN,
    decimal? tienKhachNhan,
    DateTime? thoiGianGiaoHang,
    Ulid? idKhoXuLy,
    string? ghiChu,
    int? soLuongTon,
    string? hinhAnhMinhHoa,
    bool discontinue,
    string? noiDungYeuCauHoiHang,
    string? maXinGia,
    TrangThaiDuyetGia trangThaiDuyetGia,
    GiaBanThucTe giaBanThucTe,
    decimal? giaGMinTinhThuong,
    bool laMaKhuyenMai,
    bool laMaLo)
    {
        Id = Ulid.NewUlid();
        IdBaoGia = idBaoGia;
        IdHangHoa = idHangHoa;
        MaDieuChinh = maDieuChinh;
        TenHang = tenHang;
        IdNhomHang = idNhomHang;
        ItemCode = itemCode;
        SoLuong = soLuong;
        DonViTinh = donViTinh;
        BaoHanh = baoHanh;
        DonGia = donGia;
        ThanhTienNet = thanhTienNet;
        ThanhTienHang = thanhTienHang;
        ThueGTGT = thueGTGT;
        ThueDichVuVat = thueDichVuVat;
        TongThanhTien = tongThanhTien;
        PhanTramCM = phanTramCM;
        ThueTNDN = thueTNDN;
        TienThueTNDN = tienThueTNDN;
        TienKhachNhan = tienKhachNhan;
        ThoiGianGiaoHang = thoiGianGiaoHang;
        IdKhoXuLy = idKhoXuLy;
        GhiChu = ghiChu;
        SoLuongTon = soLuongTon;
        HinhAnhMinhHoa = hinhAnhMinhHoa;
        Discontinue = discontinue;
        NoiDungYeuCauHoiHang = noiDungYeuCauHoiHang;
        MaXinGia = maXinGia;
        TrangThaiDuyetGia = trangThaiDuyetGia;
        GiaBanThucTe = giaBanThucTe;
        GiaGMinTinhThuong = giaGMinTinhThuong;
        LaMaKhuyenMai = laMaKhuyenMai;
        LaMaLo = laMaLo;
    }

    public Ulid IdBaoGia { get; private set; }
    public Ulid IdHangHoa { get; private set; }
    public string? MaDieuChinh { get; private set; }
    public string? TenHang { get; private set; }
    public Ulid? IdNhomHang { get; private set; }
    public string? ItemCode { get; private set; }
    public int SoLuong { get; private set; }
    public string DonViTinh { get; private set; }
    public int BaoHanh { get; private set; }
    public DonGia DonGia { get; private set; }
    public decimal? ThanhTienNet { get; private set; }
    public decimal? ThanhTienHang { get; private set; }
    public decimal? ThueGTGT { get; private set; }
    public decimal? ThueDichVuVat { get; private set; }
    public decimal? TongThanhTien { get; private set; }
    public decimal? PhanTramCM { get; private set; }
    public decimal? ThueTNDN { get; private set; }
    public decimal? TienThueTNDN { get; private set; }
    public decimal? TienKhachNhan { get; private set; }
    public DateTime? ThoiGianGiaoHang { get; private set; }
    public Ulid? IdKhoXuLy { get; private set; }
    public string? GhiChu { get; private set; }
    public int? SoLuongTon { get; private set; }
    public string? HinhAnhMinhHoa { get; private set; }
    public bool Discontinue { get; private set; }
    public string? NoiDungYeuCauHoiHang { get; private set; }
    public string? MaXinGia { get; private set; }
    public TrangThaiDuyetGia TrangThaiDuyetGia { get; private set; }
    public GiaBanThucTe GiaBanThucTe { get; private set; }
    public decimal? GiaGMinTinhThuong { get; private set; }
    public bool LaMaKhuyenMai { get; private set; }
    public bool LaMaLo { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public BaoGia.BaoGia BaoGia { get; private set; }

    public static BaoGiaChiTiet Create(
    Ulid idBaoGia,
    Ulid idHangHoa,
    string? maDieuChinh,
    string? tenHang,
    Ulid? idNhomHang,
    string? itemCode,
    int soLuong,
    string donViTinh,
    int baoHanh,
    DonGia donGia,
    decimal? thanhTienNet,
    decimal? thanhTienHang,
    decimal? thueGTGT,
    decimal? thueDichVuVat,
    decimal? tongThanhTien,
    decimal? phanTramCM,
    decimal? thueTNDN,
    decimal? tienThueTNDN,
    decimal? tienKhachNhan,
    DateTime? thoiGianGiaoHang,
    Ulid? idKhoXuLy,
    string? ghiChu,
    int? soLuongTon,
    string? hinhAnhMinhHoa,
    bool discontinue,
    string? noiDungYeuCauHoiHang,
    string? maXinGia,
    TrangThaiDuyetGia trangThaiDuyetGia,
    GiaBanThucTe giaBanThucTe,
    decimal? giaGMinTinhThuong,
    bool laMaKhuyenMai,
    bool laMaLo
)
    {
        return new BaoGiaChiTiet(
            idBaoGia,
            idHangHoa,
            maDieuChinh,
            tenHang,
            idNhomHang,
            itemCode,
            soLuong,
            donViTinh,
            baoHanh,
            donGia,
            thanhTienNet,
            thanhTienHang,
            thueGTGT,
            thueDichVuVat,
            tongThanhTien,
            phanTramCM,
            thueTNDN,
            tienThueTNDN,
            tienKhachNhan,
            thoiGianGiaoHang,
            idKhoXuLy,
            ghiChu,
            soLuongTon,
            hinhAnhMinhHoa,
            discontinue,
            noiDungYeuCauHoiHang,
            maXinGia,
            trangThaiDuyetGia,
            giaBanThucTe,
            giaGMinTinhThuong,
            laMaKhuyenMai,
            laMaLo
        );
    }

    public void Update(
    string? maDieuChinh,
    string? tenHang,
    Ulid? idNhomHang,
    string? itemCode,
    int? soLuong,
    string? donViTinh,
    int? baoHanh,
    DonGia? donGia,
    decimal? thanhTienNet,
    decimal? thanhTienHang,
    decimal? thueGTGT,
    decimal? thueDichVuVat,
    decimal? tongThanhTien,
    decimal? phanTramCM,
    decimal? thueTNDN,
    decimal? tienThueTNDN,
    decimal? tienKhachNhan,
    DateTime? thoiGianGiaoHang,
    Ulid? idKhoXuLy,
    string? ghiChu,
    int? soLuongTon,
    string? hinhAnhMinhHoa,
    bool? discontinue,
    string? noiDungYeuCauHoiHang,
    string? maXinGia,
    TrangThaiDuyetGia? trangThaiDuyetGia,
    GiaBanThucTe? giaBanThucTe,
    decimal? giaGMinTinhThuong,
    bool? laMaKhuyenMai,
    bool? laMaLo)
    {
        MaDieuChinh = !string.IsNullOrEmpty(maDieuChinh) ? maDieuChinh : MaDieuChinh;
        TenHang = !string.IsNullOrEmpty(tenHang) ? tenHang : TenHang;
        IdNhomHang = idNhomHang ?? IdNhomHang;
        ItemCode = !string.IsNullOrEmpty(itemCode) ? itemCode : ItemCode;
        SoLuong = soLuong ?? SoLuong;
        DonViTinh = !string.IsNullOrEmpty(donViTinh) ? donViTinh : DonViTinh;
        BaoHanh = baoHanh ?? BaoHanh;
        DonGia = donGia ?? DonGia;
        ThanhTienNet = thanhTienNet ?? ThanhTienNet;
        ThanhTienHang = thanhTienHang ?? ThanhTienHang;
        ThueGTGT = thueGTGT ?? ThueGTGT;
        ThueDichVuVat = thueDichVuVat ?? ThueDichVuVat;
        TongThanhTien = tongThanhTien ?? TongThanhTien;
        PhanTramCM = phanTramCM ?? PhanTramCM;
        ThueTNDN = thueTNDN ?? ThueTNDN;
        TienThueTNDN = tienThueTNDN ?? TienThueTNDN;
        TienKhachNhan = tienKhachNhan ?? TienKhachNhan;
        ThoiGianGiaoHang = thoiGianGiaoHang ?? ThoiGianGiaoHang;
        IdKhoXuLy = idKhoXuLy ?? IdKhoXuLy;
        GhiChu = !string.IsNullOrEmpty(ghiChu) ? ghiChu : GhiChu;
        SoLuongTon = soLuongTon ?? SoLuongTon;
        HinhAnhMinhHoa = !string.IsNullOrEmpty(hinhAnhMinhHoa) ? hinhAnhMinhHoa : HinhAnhMinhHoa;
        Discontinue = discontinue ?? Discontinue;
        NoiDungYeuCauHoiHang = !string.IsNullOrEmpty(noiDungYeuCauHoiHang) ? noiDungYeuCauHoiHang : NoiDungYeuCauHoiHang;
        MaXinGia = !string.IsNullOrEmpty(maXinGia) ? maXinGia : MaXinGia;
        TrangThaiDuyetGia = trangThaiDuyetGia ?? TrangThaiDuyetGia;
        GiaBanThucTe = giaBanThucTe ?? GiaBanThucTe;
        GiaGMinTinhThuong = giaGMinTinhThuong ?? GiaGMinTinhThuong;
        LaMaKhuyenMai = laMaKhuyenMai ?? LaMaKhuyenMai;
        LaMaLo = laMaLo ?? LaMaLo;
    }
}
