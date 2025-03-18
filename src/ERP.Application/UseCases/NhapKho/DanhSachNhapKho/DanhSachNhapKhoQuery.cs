using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.NhapKho.DanhSachNhapKho;
public sealed record DanhSachNhapKhoQuery(string? Tungay, string? Denngay, string? IdNhapKho, string? DoiTuong, string? NguoiTao, string? LoaiNhapKho, string? MaSoPo, string? ChiNhanh, int? SoTrang, int? SoBanGhi) : IQuery;

