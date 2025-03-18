using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiSuaGia.CreateDeNghiSuaGia;
public sealed record CreateDeNghiSuaGiaCommand(
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
    string? ngayDuyet,
    string trangThaiDuyet,
    string? ghiChuDuyet) : ICommand;
