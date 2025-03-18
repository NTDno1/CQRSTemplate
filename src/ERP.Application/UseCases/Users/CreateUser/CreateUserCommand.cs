using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.Users.CreateUser;

public sealed record CreateUserCommand(
        string Username,
        string HoTen,
        string Password) : ICommand;

