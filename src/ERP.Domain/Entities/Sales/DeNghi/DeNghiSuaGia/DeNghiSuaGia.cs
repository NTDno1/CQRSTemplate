using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Shared;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiSuaGia;


public sealed class DeNghiSuaGia : AggregateRoot, ISoftDelete
{
    private DeNghiSuaGia()
    {

    }

    public DeNghiSuaGia(
        Ulid idChiTietXuatKho,
        decimal giaNetCu,
        decimal giaNetMoi,
        decimal giaCMCu,
        decimal giaCMMoi,
        decimal vatCu,
        decimal vatMoi,
        string maChuan,
        string lyDoSua,
        DuyetDon duyetDon)
    {
        IdChiTietXuatKho = idChiTietXuatKho;
        GiaNetCu = giaNetCu;
        GiaNetMoi = giaNetMoi;
        GiaCMCu = giaCMCu;
        GiaCMMoi = giaCMMoi;
        VatCu = vatCu;
        VatMoi = vatMoi;
        MaChuan = maChuan;
        LyDoSua = lyDoSua;
        DuyetDon = duyetDon;
    }

    public Ulid IdChiTietXuatKho { get; private set; }
    public decimal GiaNetCu { get; private set; }
    public decimal GiaNetMoi { get; private set; }
    public decimal GiaCMCu { get; private set; }
    public decimal GiaCMMoi { get; private set; }
    public decimal VatCu { get; private set; }
    public decimal VatMoi { get; private set; }
    public string MaChuan { get; private set; }
    public string LyDoSua { get; private set; }
    public DuyetDon DuyetDon { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public static DeNghiSuaGia Create(
        Ulid idChiTietXuatKho,
        decimal giaNetCu,
        decimal giaNetMoi,
        decimal giaCMCu,
        decimal giaCMMoi,
        decimal vatCu,
        decimal vatMoi,
        string maChuan,
        string lyDoSua,
        string? nguoiDuyet,
        DateTime? ngayDuyet,
        string trangThaiDuyet,
        string? ghiChuDuyet)
    {
        var trangThaiDonDuyet = TrangThaiDonDuyet.FromValue(trangThaiDuyet);
        var duyetDon = DuyetDon.Create(nguoiDuyet, ngayDuyet, trangThaiDonDuyet, ghiChuDuyet);
        var denghiSuaGia = new DeNghiSuaGia(
            idChiTietXuatKho,
            giaNetCu,
            giaNetMoi,
            giaCMCu,
            giaCMMoi,
            vatCu,
            vatMoi,
            maChuan,
            lyDoSua,
            duyetDon);

        return denghiSuaGia;
    }

    public void Update(
    decimal? giaNetMoi = null,
    decimal? giaCMMoi = null,
    decimal? vatMoi = null,
    string? maChuan = null,
    string? lyDoSua = null,
    DuyetDon? duyetDon = null)
    {
        GiaNetMoi = giaNetMoi ?? GiaNetMoi;
        GiaCMMoi = giaCMMoi ?? GiaCMMoi;
        VatMoi = vatMoi ?? VatMoi;
        MaChuan = maChuan ?? MaChuan;
        LyDoSua = lyDoSua ?? LyDoSua;
        DuyetDon = duyetDon ?? DuyetDon;
    }
}
