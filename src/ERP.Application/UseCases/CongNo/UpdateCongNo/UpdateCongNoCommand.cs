using System;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.UpdateCongNo;
public sealed record UpdateCongNoCommand
(
    Ulid Id,
    Ulid IdKhachHang,
    decimal? SoTienHenThanhToan,
    string? KetQuaThuHoi,
    string saleComment,
    string acctComment,
    string noiDungComment
    ) : ICommand;
