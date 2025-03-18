using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.BaoGia.DeleteBaoGia;
public sealed record DeleteBaoGiaCommand(
    Ulid IdBaoGia
    ) : ICommand;
