using ERP.Domain.Abstractions.Aggregates;
using ERP.Domain.Abstractions.Entities;
using ERP.Domain.Entities.Shared;

namespace ERP.Domain.Entities.Sales.DeNghi.DeNghiTraLai;

public sealed class DeNghiTraLai : AggregateRoot, ISoftDelete
{
    private readonly List<DeNghiTraLaiChiTiet> _deNghiTraLaiChiTiets;

    private DeNghiTraLai()
    {
        _deNghiTraLaiChiTiets = [];
    }

    public DeNghiTraLai(
        Ulid id,
        string maDeNghi,
        DateOnly ngayDeNghi,
        string nguoiDeNghi,
        string maNhatHang,
        string soPhieuXuatKho,
        string nguoiTraLai,
        string lyDoDeNghi,
        DuyetDon leaderDuyet,
        DuyetDon kyThuatDuyet,
        string? ghiChuDonHang,
        bool canDiLayHang,
        string diaChiLayHang,
        string nguoiGiaoHangThucTe,
        string? ghiChuGiaoNhan,
        bool daNhapKho,
        string? soPhieuNhapKho,
        TrucThuoc trucThuoc,
        Ulid? idKhoNhapHang,
        HinhThucTraLai hinhThucTraLai,
        decimal? soTienPhiNhapLai,
        string? lyDoThuPhiNhapLai)
    {
        Id = id;
        MaDeNghi = maDeNghi;
        NgayDeNghi = ngayDeNghi;
        NguoiDeNghi = nguoiDeNghi;
        MaNhatHang = maNhatHang;
        SoPhieuXuatKho = soPhieuXuatKho;
        NguoiTraLai = nguoiTraLai;
        LyDoDeNghi = lyDoDeNghi;
        LeaderDuyet = leaderDuyet;
        KyThuatDuyet = kyThuatDuyet;
        GhiChuDonHang = ghiChuDonHang;
        CanDiLayHang = canDiLayHang;
        DiaChiLayHang = diaChiLayHang;
        NguoiGiaoHangThucTe = nguoiGiaoHangThucTe;
        GhiChuGiaoNhan = ghiChuGiaoNhan;
        DaNhapKho = daNhapKho;
        SoPhieuNhapKho = soPhieuNhapKho;
        TrucThuoc = trucThuoc;
        IdKhoNhapHang = idKhoNhapHang;
        HinhThucTraLai = hinhThucTraLai;
        SoTienPhiNhapLai = soTienPhiNhapLai;
        LyDoThuPhiNhapLai = lyDoThuPhiNhapLai;
        _deNghiTraLaiChiTiets = new List<DeNghiTraLaiChiTiet>();
    }

    public string MaDeNghi { get; private set; }

    public DateOnly NgayDeNghi { get; private set; }
    public string NguoiDeNghi { get; private set; }
    public string MaNhatHang { get; private set; }
    public string SoPhieuXuatKho { get; private set; }
    public string NguoiTraLai { get; private set; }
    public string LyDoDeNghi { get; private set; }
    public DuyetDon LeaderDuyet { get; private set; }
    public DuyetDon KyThuatDuyet { get; private set; }
    public string? GhiChuDonHang { get; private set; }
    public bool CanDiLayHang { get; private set; }
    public string DiaChiLayHang { get; private set; }
    public string NguoiGiaoHangThucTe { get; private set; }
    public string? GhiChuGiaoNhan { get; private set; }
    public bool DaNhapKho { get; private set; }
    public string? SoPhieuNhapKho { get; private set; }
    public TrucThuoc TrucThuoc { get; private set; }
    public Ulid? IdKhoNhapHang { get; private set; }
    public HinhThucTraLai HinhThucTraLai { get; private set; }
    public decimal? SoTienPhiNhapLai { get; private set; }
    public string? LyDoThuPhiNhapLai { get; private set; }

    public bool IsDeleted { get; set; }
    public DateTime? NgayXoa { get; set; }

    public IReadOnlyCollection<DeNghiTraLaiChiTiet> DeNghiTraLaiChiTiets => _deNghiTraLaiChiTiets.AsReadOnly();

    public static DeNghiTraLai Create(
    Ulid id,
    string maDeNghi,
    DateOnly ngayDeNghi,
    string nguoiDeNghi,
    string maNhatHang,
    string soPhieuXuatKho,
    string nguoiTraLai,
    string lyDoDeNghi,
    string? leaderDuyet,
    DateTime? ngayLeaderDuyet,
    string trangThaiLeaderDuyet,
    string? ghiChuLeaderDuyet,
    string? kyThuatDuyet,
    DateTime? ngayKyThuatDuyet,
    string trangThaiKyThuatDuyet,
    string? ghiChuKyThuatDuyet,
    string? ghiChuDonHang,
    bool canDiLayHang,
    string diaChiLayHang,
    string nguoiGiaoHangThucTe,
    string? ghiChuGiaoNhan,
    bool daNhapKho,
    string? soPhieuNhapKho,
    string trucThuoc,
    Ulid? idKhoNhapHang,
    string hinhThucTraLai,
    decimal? soTienPhiNhapLai,
    string? lyDoThuPhiNhapLai,
    List<DeNghiTraLaiChiTiet>? deNghiTraLaiChiTiets)
    {
        var trangThaiDonLeaderDuyet = TrangThaiDonDuyet.FromValue(trangThaiLeaderDuyet);
        var createLeaderDuyet = DuyetDon.Create(leaderDuyet, ngayLeaderDuyet, trangThaiDonLeaderDuyet, ghiChuLeaderDuyet);
        var trangThaiDonKyThuatDuyet = TrangThaiDonDuyet.FromValue(trangThaiKyThuatDuyet);
        var createKyThuatDuyet = DuyetDon.Create(kyThuatDuyet, ngayKyThuatDuyet, trangThaiDonKyThuatDuyet, ghiChuKyThuatDuyet);
        var createTrucThuoc = TrucThuoc.FromValue(trucThuoc);
        var createHinhThucTraLai = HinhThucTraLai.FromValue(hinhThucTraLai);
        var deNghiTralai = new DeNghiTraLai(
            id,
            maDeNghi,
            ngayDeNghi,
            nguoiDeNghi,
            maNhatHang,
            soPhieuXuatKho,
            nguoiTraLai,
            lyDoDeNghi,
            createLeaderDuyet,
            createKyThuatDuyet,
            ghiChuDonHang,
            canDiLayHang,
            diaChiLayHang,
            nguoiGiaoHangThucTe,
            ghiChuGiaoNhan,
            daNhapKho,
            soPhieuNhapKho,
            createTrucThuoc,
            idKhoNhapHang,
            createHinhThucTraLai,
            soTienPhiNhapLai,
            lyDoThuPhiNhapLai);
        deNghiTralai._deNghiTraLaiChiTiets.AddRange(deNghiTraLaiChiTiets);
        return deNghiTralai;
    }

    public void Update(
    string? nguoiDeNghi,
    string? maNhatHang,
    string? soPhieuXuatKho,
    string? nguoiTraLai,
    string? lyDoDeNghi,
    string? leaderDuyet,
    DateTime? ngayLeaderDuyet,
    string? trangThaiLeaderDuyet,
    string? ghiChuLeaderDuyet,
    string? kyThuatDuyet,
    DateTime? ngayKyThuatDuyet,
    string? trangThaiKyThuatDuyet,
    string? ghiChuKyThuatDuyet,
    string? ghiChuDonHang,
    bool? canDiLayHang,
    string? diaChiLayHang,
    string? nguoiGiaoHangThucTe,
    string? ghiChuGiaoNhan,
    bool? daNhapKho,
    string? soPhieuNhapKho,
    string? trucThuoc,
    Ulid? idKhoNhapHang,
    string? hinhThucTraLai,
    decimal? soTienPhiNhapLai,
    string? lyDoThuPhiNhapLai)
    {
        var trangThaiDonLeaderDuyet = TrangThaiDonDuyet.FromValue(trangThaiLeaderDuyet ?? LeaderDuyet.TrangThai.Value.ToString());
        var updateLeaderDuyet = DuyetDon.Create(leaderDuyet ?? LeaderDuyet.IdUser, ngayLeaderDuyet ?? LeaderDuyet.Ngay, trangThaiDonLeaderDuyet, ghiChuLeaderDuyet ?? LeaderDuyet.GhiChuDuyet);

        var trangThaiDonKyThuatDuyet = TrangThaiDonDuyet.FromValue(trangThaiKyThuatDuyet ?? KyThuatDuyet.TrangThai.Value.ToString());
        var updateKyThuatDuyet = DuyetDon.Create(kyThuatDuyet ?? KyThuatDuyet.IdUser, ngayKyThuatDuyet ?? KyThuatDuyet.Ngay, trangThaiDonKyThuatDuyet, ghiChuKyThuatDuyet ?? KyThuatDuyet.GhiChuDuyet);

        var updateTrucThuoc = TrucThuoc.FromValue(trucThuoc ?? TrucThuoc.Value.ToString());
        var updateHinhThucTraLai = HinhThucTraLai.FromValue(hinhThucTraLai ?? HinhThucTraLai.Value.ToString());

        NguoiDeNghi = nguoiDeNghi ?? NguoiDeNghi;
        MaNhatHang = maNhatHang ?? MaNhatHang;
        SoPhieuXuatKho = soPhieuXuatKho ?? SoPhieuXuatKho;
        NguoiTraLai = nguoiTraLai ?? NguoiTraLai;
        LyDoDeNghi = lyDoDeNghi ?? LyDoDeNghi;
        LeaderDuyet = updateLeaderDuyet;
        KyThuatDuyet = updateKyThuatDuyet;
        GhiChuDonHang = ghiChuDonHang ?? GhiChuDonHang;
        CanDiLayHang = canDiLayHang ?? CanDiLayHang;
        DiaChiLayHang = diaChiLayHang ?? DiaChiLayHang;
        NguoiGiaoHangThucTe = nguoiGiaoHangThucTe ?? NguoiGiaoHangThucTe;
        GhiChuGiaoNhan = ghiChuGiaoNhan ?? GhiChuGiaoNhan;
        DaNhapKho = daNhapKho ?? DaNhapKho;
        SoPhieuNhapKho = soPhieuNhapKho ?? SoPhieuNhapKho;
        TrucThuoc = updateTrucThuoc;
        IdKhoNhapHang = idKhoNhapHang ?? IdKhoNhapHang;
        HinhThucTraLai = updateHinhThucTraLai;
        SoTienPhiNhapLai = soTienPhiNhapLai ?? SoTienPhiNhapLai;
        LyDoThuPhiNhapLai = lyDoThuPhiNhapLai ?? LyDoThuPhiNhapLai;
    }

    public void UpdateDeNghiTraLaiChiTiet(ICollection<DeNghiTraLaiChiTiet> updatedDetails)
    {
        var missingIds = _deNghiTraLaiChiTiets.Where(ct => !updatedDetails.Any(ud => ud.Id == ct.Id)).Select(ct => ct.Id).ToList();
        foreach (Ulid id in missingIds)
        {
            DeNghiTraLaiChiTiet? chitiet = _deNghiTraLaiChiTiets.Find(u => u.Id == id);
            if (chitiet != null)
            {
                _deNghiTraLaiChiTiets.Remove(chitiet);
            }
        }

        foreach (DeNghiTraLaiChiTiet updatedDetail in updatedDetails)
        {
            DeNghiTraLaiChiTiet? existingDetail = _deNghiTraLaiChiTiets.Find(d => d.Id == updatedDetail.Id);
            if (existingDetail != null)
            {
                existingDetail.Update(
                    existingDetail.IdHangHoa,
                    existingDetail.MaDieuChinh,
                    existingDetail.SoLuong,
                    existingDetail.DonGiaBan,
                    existingDetail.DonGiaVon,
                    existingDetail.GhiChu,
                    existingDetail.ThueGTGT,
                    existingDetail.IdChiTietXuatKho,
                    existingDetail.DaNhapKho,
                    existingDetail.SoLuongDaNhap);
            }
            else
            {
                _deNghiTraLaiChiTiets.Add(updatedDetail);
            }
        }
    }
}
