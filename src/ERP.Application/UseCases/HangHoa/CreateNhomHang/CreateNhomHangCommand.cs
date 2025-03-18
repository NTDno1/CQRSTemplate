using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.HangHoa.CreateNhomHang;
public sealed record CreateNhomHangCommand(string maNhomHang,
    Ulid? idNhomHangCha,
    string phanLoaiNhom,
    string? ghiChu,
    string muaHangPhuTrach,
    string muaHangPhuTrachNuocNgoai,
    string? leader,
    string sub,
    List<Ulid> hangHoas) : ICommand;
