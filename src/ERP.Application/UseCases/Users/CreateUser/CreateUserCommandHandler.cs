using ERP.Application.Abstractions.Authentication;
using ERP.Domain.Entities.System.Users;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.Users.CreateUser;
public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordService _passwordService;

    public CreateUserCommandHandler(IUserRepository userRepository, IPasswordService passwordService)
    {
        _userRepository = userRepository;
        _passwordService = passwordService;
    }

    public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        try
        {

            string passwordHashed = _passwordService.HashPassword(request.Password);

            var user = User.Create(
                request.Username,
                request.HoTen,
                passwordHashed,
                passwordHashed);

            await _userRepository.Add(user);
            return Result.Success();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
