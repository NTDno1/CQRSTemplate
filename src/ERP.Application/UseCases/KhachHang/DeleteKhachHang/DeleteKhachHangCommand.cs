using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.KhachHang.DeleteKhachHang;
public sealed record DeleteKhachHangCommand(
    Ulid IdKhachHang
    ) : ICommand;
