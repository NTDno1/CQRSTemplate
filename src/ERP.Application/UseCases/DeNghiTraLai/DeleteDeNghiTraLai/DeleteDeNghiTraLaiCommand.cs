using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiTraLai.DeleteDeNghiTraLai;
public sealed record DeleteDeNghiTraLaiCommand(Ulid idDeNghi) : ICommand;
