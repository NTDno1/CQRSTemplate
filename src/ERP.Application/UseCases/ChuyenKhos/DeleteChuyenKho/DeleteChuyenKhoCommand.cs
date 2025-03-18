using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.WhChuyenKhos.DeleteWhChuyenKho;
public sealed record DeleteChuyenKhoCommand(
    Ulid idChuyenKho
    ) : ICommand;
