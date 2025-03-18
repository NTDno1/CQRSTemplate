using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;

public sealed class DeNghiTraLaiChiTiet : AggregateRoot
{

    private DeNghiTraLaiChiTiet()
    {

    }

    public DeNghiTraLaiChiTiet(
        Ulid idDeNghiTraLai,
        Ulid idHangHoa,
        string maDieuChinh,
        int soLuong,
        decimal donGiaBan,
        decimal donGiaVon,
        string ghiChu,
        decimal thueGTGT,
        Ulid idChiTietXuatKho,
        bool daNhapKho,
        int soLuongDaNhap)
    {
        Id = Ulid.NewUlid();
        IdDeNghiTraLai = idDeNghiTraLai;
        IdHangHoa = idHangHoa;
        MaDieuChinh = maDieuChinh;
        SoLuong = soLuong;
        DonGiaBan = donGiaBan;
        DonGiaVon = donGiaVon;
        GhiChu = ghiChu;
        ThueGTGT = thueGTGT;
        IdChiTietXuatKho = idChiTietXuatKho;
        DaNhapKho = daNhapKho;
        SoLuongDaNhap = soLuongDaNhap;
    }

    public Ulid IdDeNghiTraLai { get; private set; }
    public Ulid IdHangHoa { get; private set; }
    public string MaDieuChinh { get; private set; }
    public int SoLuong { get; private set; }
    public decimal DonGiaBan { get; private set; }
    public decimal DonGiaVon { get; private set; }
    public string GhiChu { get; private set; }
    public decimal ThueGTGT { get; private set; }
    public Ulid IdChiTietXuatKho { get; private set; }
    public bool DaNhapKho { get; private set; }
    public int SoLuongDaNhap { get; private set; }

    public DeNghiTraLai DeNghiTraLai { get; private set; }

    public static DeNghiTraLaiChiTiet Create(
    Ulid idDeNghiTraLai,
    Ulid idHangHoa,
    string maDieuChinh,
    int soLuong,
    decimal donGiaBan,
    decimal donGiaVon,
    string ghiChu,
    decimal thueGTGT,
    Ulid idChiTietXuatKho,
    bool daNhapKho,
    int soLuongDaNhap)
    {
        return new DeNghiTraLaiChiTiet(
            idDeNghiTraLai,
            idHangHoa,
            maDieuChinh,
            soLuong,
            donGiaBan,
            donGiaVon,
            ghiChu,
            thueGTGT,
            idChiTietXuatKho,
            daNhapKho,
            soLuongDaNhap
        );
    }

    public void Update(
    Ulid? idHangHoa = null,
    string? maDieuChinh = null,
    int? soLuong = null,
    decimal? donGiaBan = null,
    decimal? donGiaVon = null,
    string? ghiChu = null,
    decimal? thueGTGT = null,
    Ulid? idChiTietXuatKho = null,
    bool? daNhapKho = null,
    int? soLuongDaNhap = null)
    {
        IdHangHoa = idHangHoa ?? IdHangHoa;
        MaDieuChinh = maDieuChinh ?? MaDieuChinh;
        SoLuong = soLuong ?? SoLuong;
        DonGiaBan = donGiaBan ?? DonGiaBan;
        DonGiaVon = donGiaVon ?? DonGiaVon;
        GhiChu = ghiChu ?? GhiChu;
        ThueGTGT = thueGTGT ?? ThueGTGT;
        IdChiTietXuatKho = idChiTietXuatKho ?? IdChiTietXuatKho;
        DaNhapKho = daNhapKho ?? DaNhapKho;
        SoLuongDaNhap = soLuongDaNhap ?? SoLuongDaNhap;
    }
}
