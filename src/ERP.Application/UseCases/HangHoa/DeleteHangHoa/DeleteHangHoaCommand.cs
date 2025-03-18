using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.HangHoa.DeleteHangHoa;
public sealed record DeleteHangHoaCommand(Ulid IdHangHoa) : ICommand;
