using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiTraLai.CreateDeNghiTraLai;
public sealed record CreateDeNghiTraLaiCommand(
    string ngayDeNghi,
    string nguoiDeNghi,
    string maNhatHang,
    string soPhieuXuatKho,
    string nguoiTraLai,
    string lyDoDeNghi,
    string? leaderDuyet,
    string? ngayLeaderDuyet,
    string trangThaiLeaderDuyet,
    string? ghiChuLeaderDuyet,
    string? kyThuatDuyet,
    string? ngayKyThuatDuyet,
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
    List<DeNghiTraLaiChiTietCommand> deNghiTraLaiChiTiets) : ICommand;

public sealed record DeNghiTraLaiChiTietCommand(Ulid IdHangHoa,
    string MaDieuChinh,
    int SoLuong,
    decimal DonGiaBan,
    decimal DonGiaVon,
    string GhiChu,
    decimal ThueGTGT,
    Ulid IdChiTietXuatKho,
    bool DaNhapKho,
    int SoLuongDaNhap);

