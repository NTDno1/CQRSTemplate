using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.DeNghiThanhToanCM.DeleteDeNghiThanhToanCM;
public sealed record DeleteDNThanhToanCMCommand
(
     Ulid Id
) : ICommand;
