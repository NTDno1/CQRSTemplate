using ERP.Domain.Abstractions.Aggregates;

namespace ERP.Domain.Entities.WareHouses.ChuyenKho;

public sealed class ChuyenKhoChiTiet : AggregateRoot
{
    private ChuyenKhoChiTiet()
    {

    }

    public ChuyenKhoChiTiet(Ulid idChuyenKho, Ulid idHangHoa, string? maDieuChinh, Ulid? idXuatTaiKho, Ulid? idNhapTaiKho, decimal soLuong, string tk_No, string tk_Co, decimal donGia, decimal thanhTien, NhatHang nhathang)
    {
        Id = Ulid.NewUlid();
        IdChuyenKho = idChuyenKho;
        IdHangHoa = idHangHoa;
        MaDieuChinh = maDieuChinh;
        IdXuatTaiKho = idXuatTaiKho;
        IdNhapTaiKho = idNhapTaiKho;
        SoLuong = soLuong;
        Tk_No = tk_No;
        Tk_Co = tk_Co;
        DonGia = donGia;
        ThanhTien = thanhTien;
        NhatHang = nhathang;
    }

    public Ulid IdChuyenKho { get; private set; }

    public Ulid IdHangHoa { get; private set; }

    public string? MaDieuChinh { get; private set; }

    public Ulid? IdXuatTaiKho { get; set; }

    public Ulid? IdNhapTaiKho { get; set; }

    public decimal SoLuong { get; private set; }

    public string Tk_No { get; private set; }

    public string Tk_Co { get; private set; }

    public decimal DonGia { get; private set; }

    public decimal ThanhTien { get; private set; }

    public NhatHang NhatHang { get; private set; }

    public ChuyenKho WhChuyenKho { get; set; }

    public static ChuyenKhoChiTiet Create(
        Ulid chuyenKhoId,
        Ulid IdHangHoa,
        string? maDieuChinh,
        Ulid? idXuatTaiKho,
        Ulid? idNhapTaiKho,
        decimal soLuong,
        decimal donGia,
        decimal thanhTien,
        NhatHang nhatHang)
    {
        return new ChuyenKhoChiTiet(chuyenKhoId, IdHangHoa, maDieuChinh, idXuatTaiKho, idNhapTaiKho, soLuong, string.Empty, string.Empty, donGia, thanhTien, nhatHang);

    }

    public void Update(
        Ulid? idHangHoa,
        string? maDieuChinh,
        Ulid? idXuatTaiKho,
        Ulid? idNhapTaiKho,
        decimal soLuong,
        string tk_No,
        string tk_Co,
        decimal donGia,
        decimal thanhTien,
        NhatHang nhatHang)
    {
        IdHangHoa = idHangHoa ?? IdHangHoa;
        MaDieuChinh = !string.IsNullOrEmpty(maDieuChinh) ? maDieuChinh : MaDieuChinh;
        IdXuatTaiKho = idXuatTaiKho ?? IdXuatTaiKho;
        IdNhapTaiKho = idNhapTaiKho ?? IdNhapTaiKho;
        SoLuong = soLuong;
        Tk_Co = !string.IsNullOrEmpty(tk_Co) ? tk_Co : Tk_Co;
        Tk_No = !string.IsNullOrEmpty(tk_No) ? tk_No : Tk_No;
        DonGia = donGia;
        ThanhTien = thanhTien;
        NhatHang = nhatHang;
    }
}
