using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;

namespace ERP.Domain.Entities.PURC.HangHoa;
public sealed class HangHoa : AggregateRoot, ISoftDelete
{
    private readonly List<HinhAnhHangHoa> _hinhAnhHangHoas;
    private HangHoa()
    {
        _hinhAnhHangHoas = [];
    }

    private HangHoa(string maHang, string maChuan, string? hsCode, string? thongSoKyThuat, string tenHang, Ulid? idNhomHang, string donViTinh, float? khoiLuong, string? xuatXu, int? vat, decimal? giaNhap, decimal? giaBan1, decimal? giaBan2, decimal? giaBan3, decimal? giaBan4, decimal? giaBan5, decimal? ck1, decimal? ck2, decimal? ck3, decimal? ck4, decimal? ck5, string? maChuyenDoi, string? ghiChu, string? linkSanPham, string? phuKienDiKem, int? soNgayCapHang, bool? isTachMa, string? tinhTrangHangHoa, string? dongSanPham, MangKinhDoanh mangKinhDoanh, decimal? giaDaiLy, string? phanLoaiHangHoa, string? tenHangBaoCao)
    {
        Id = Ulid.NewUlid();
        MaHang = maHang;
        MaChuan = maChuan;
        HsCode = hsCode;
        ThongSoKyThuat = thongSoKyThuat;
        TenHang = tenHang;
        IdNhomHang = idNhomHang;
        DonViTinh = donViTinh;
        KhoiLuong = khoiLuong;
        XuatXu = xuatXu;
        Vat = vat;
        GiaNhap = giaNhap;
        GiaBan1 = giaBan1;
        GiaBan2 = giaBan2;
        GiaBan3 = giaBan3;
        GiaBan4 = giaBan4;
        GiaBan5 = giaBan5;
        Ck1 = ck1;
        Ck2 = ck2;
        Ck3 = ck3;
        Ck4 = ck4;
        Ck5 = ck5;
        MaChuyenDoi = maChuyenDoi;
        GhiChu = ghiChu;
        LinkSanPham = linkSanPham;
        PhuKienDiKem = phuKienDiKem;
        SoNgayCapHang = soNgayCapHang;
        IsTachMa = isTachMa;
        TinhTrangHangHoa = tinhTrangHangHoa;
        DongSanPham = dongSanPham;
        MangKinhDoanh = mangKinhDoanh;
        GiaDaiLy = giaDaiLy;
        PhanLoaiHangHoa = phanLoaiHangHoa;
        TenHangBaoCao = tenHangBaoCao;
    }

    public string MaHang { get; private set; }
    public string MaChuan { get; private set; }
    public string? HsCode { get; private set; }
    public string? ThongSoKyThuat { get; private set; }
    public string TenHang { get; private set; }
    public Ulid? IdNhomHang { get; private set; }
    public string DonViTinh { get; private set; }
    public float? KhoiLuong { get; private set; }
    public string? XuatXu { get; private set; }
    public int? Vat { get; private set; }
    public decimal? GiaNhap { get; private set; }
    public decimal? GiaBan1 { get; private set; }
    public decimal? GiaBan2 { get; private set; }
    public decimal? GiaBan3 { get; private set; }
    public decimal? GiaBan4 { get; private set; }
    public decimal? GiaBan5 { get; private set; }
    public decimal? Ck1 { get; private set; }
    public decimal? Ck2 { get; private set; }
    public decimal? Ck3 { get; private set; }
    public decimal? Ck4 { get; private set; }
    public decimal? Ck5 { get; private set; }
    public string? MaChuyenDoi { get; private set; }
    public string? GhiChu { get; private set; }
    public string? LinkSanPham { get; private set; }
    public string? PhuKienDiKem { get; private set; }
    public int? SoNgayCapHang { get; private set; }
    public bool? IsTachMa { get; private set; }
    public string? TinhTrangHangHoa { get; private set; }
    public string? DongSanPham { get; private set; }
    public MangKinhDoanh MangKinhDoanh { get; private set; }
    public decimal? GiaDaiLy { get; private set; }
    public string? PhanLoaiHangHoa { get; private set; }
    public string? TenHangBaoCao { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public NhomHang? NhomHang { get; private set; }
    public IReadOnlyCollection<HinhAnhHangHoa> HinhAnhHangHoas => _hinhAnhHangHoas.AsReadOnly();


    public static HangHoa Create(
        string maHang,
        string maChuan,
        string? hsCode,
        string? thongSoKyThuat,
        string tenHang,
        Ulid? idNhomHang,
        string donViTinh,
        float? khoiLuong,
        string? xuatXu,
        int? vat,
        decimal? giaNhap,
        decimal? giaBan1,
        decimal? giaBan2,
        decimal? giaBan3,
        decimal? giaBan4,
        decimal? giaBan5,
        decimal? ck1,
        decimal? ck2,
        decimal? ck3,
        decimal? ck4,
        decimal? ck5,
        string? maChuyenDoi,
        string? ghiChu,
        string? linkSanPham,
        string? phuKienDiKem,
        int? soNgayCapHang,
        bool? isTachMa,
        string? tinhTrangHangHoa,
        string? dongSanPham,
        string mangKinhDoanh,
        decimal? giaDaiLy,
        string? phanLoaiHangHoa,
        string? tenHangBaoCao,
        List<string> hinhAnhs
        )
    {

        var mangKinhDoanhEnum = MangKinhDoanh.FromValue(mangKinhDoanh);

        var hangHoa = new HangHoa(
            maHang,
            maChuan,
            hsCode,
            thongSoKyThuat,
            tenHang,
            idNhomHang,
            donViTinh,
            khoiLuong,
            xuatXu,
            vat,
            giaNhap,
            giaBan1,
            giaBan2,
            giaBan3,
            giaBan4,
            giaBan5,
            ck1,
            ck2,
            ck3,
            ck4,
            ck5,
            maChuyenDoi,
            ghiChu,
            linkSanPham,
            phuKienDiKem,
            soNgayCapHang,
            isTachMa,
            tinhTrangHangHoa,
            dongSanPham,
            mangKinhDoanhEnum,
            giaDaiLy,
            phanLoaiHangHoa,
            tenHangBaoCao);

        foreach (string hinhAnh in hinhAnhs)
        {
            var hinhAnhHangHoa = HinhAnhHangHoa.Create(hangHoa.Id, hinhAnh);
            hangHoa._hinhAnhHangHoas.Add(hinhAnhHangHoa);
        }

        return hangHoa;
    }

    public void Update(
        string? maChuan,
        string? hsCode,
        string? thongSoKyThuat,
        string? tenHang,
        Ulid? idNhomHang,
        string? donViTinh,
        float? khoiLuong,
        string? xuatXu,
        int? vat,
        decimal? giaNhap,
        decimal? giaBan1,
        decimal? giaBan2,
        decimal? giaBan3,
        decimal? giaBan4,
        decimal? giaBan5,
        decimal? ck1,
        decimal? ck2,
        decimal? ck3,
        decimal? ck4,
        decimal? ck5,
        string? maChuyenDoi,
        string? ghiChu,
        string? linkSanPham,
        string? phuKienDiKem,
        int? soNgayCapHang,
        bool? isTachMa,
        string? tinhTrangHangHoa,
        string? dongSanPham,
        string? mangKinhDoanh,
        decimal? giaDaiLy,
        string? phanLoaiHangHoa,
        string? tenHangBaoCao,
        List<string>? hinhAnhs)
    {
        if (hinhAnhs != null)
        {
            _hinhAnhHangHoas.Clear();
            foreach (string hinhAnh in hinhAnhs)
            {
                var hinhAnhHangHoa = HinhAnhHangHoa.Create(Id, hinhAnh);
                _hinhAnhHangHoas.Add(hinhAnhHangHoa);
            }
        }

        MaChuan = maChuan ?? MaChuan;
        HsCode = hsCode ?? HsCode;
        ThongSoKyThuat = thongSoKyThuat ?? ThongSoKyThuat;
        TenHang = tenHang ?? TenHang;
        IdNhomHang = idNhomHang ?? IdNhomHang;
        DonViTinh = donViTinh ?? DonViTinh;
        KhoiLuong = khoiLuong ?? KhoiLuong;
        XuatXu = xuatXu ?? XuatXu;
        Vat = vat ?? Vat;
        GiaNhap = giaNhap ?? GiaNhap;
        GiaBan1 = giaBan1 ?? GiaBan1;
        GiaBan2 = giaBan2 ?? GiaBan2;
        GiaBan3 = giaBan3 ?? GiaBan3;
        GiaBan4 = giaBan4 ?? GiaBan4;
        GiaBan5 = giaBan5 ?? GiaBan5;
        Ck1 = ck1 ?? Ck1;
        Ck2 = ck2 ?? Ck2;
        Ck3 = ck3 ?? Ck3;
        Ck4 = ck4 ?? Ck4;
        Ck5 = ck5 ?? Ck5;
        MaChuyenDoi = maChuyenDoi ?? MaChuyenDoi;
        GhiChu = ghiChu ?? GhiChu;
        LinkSanPham = linkSanPham ?? LinkSanPham;
        PhuKienDiKem = phuKienDiKem ?? PhuKienDiKem;
        SoNgayCapHang = soNgayCapHang ?? SoNgayCapHang;
        IsTachMa = isTachMa ?? IsTachMa;
        TinhTrangHangHoa = tinhTrangHangHoa ?? TinhTrangHangHoa;
        DongSanPham = dongSanPham ?? DongSanPham;
        MangKinhDoanh = mangKinhDoanh != null ? MangKinhDoanh.FromValue(mangKinhDoanh) : MangKinhDoanh;
        GiaDaiLy = giaDaiLy ?? GiaDaiLy;
        PhanLoaiHangHoa = phanLoaiHangHoa ?? PhanLoaiHangHoa;
        TenHangBaoCao = tenHangBaoCao ?? TenHangBaoCao;
    }


}
