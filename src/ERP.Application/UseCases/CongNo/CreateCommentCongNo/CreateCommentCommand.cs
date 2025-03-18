using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.CongNo.CreateCommentCongNo;
public sealed record CreateCommentCommand(
    Ulid idCongNo,
    Ulid idKhachHang,
    string? saleComment,
    string? acctComment,
    string noiDungComment) : ICommand;
