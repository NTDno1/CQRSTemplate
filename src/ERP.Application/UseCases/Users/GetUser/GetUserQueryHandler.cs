using ERP.Application.Abstractions.Authentication;
using ERP.Domain.Entities.System.Users;
using ERP.Share.Abstractions.Shared;

namespace ERP.Application.UseCases.Users.GetUser;
public sealed class GetUserQueryHandler : IQueryHandler<GetUserQuery>
{

    private readonly IUserContext _userContext;
    private readonly IUserRepository _userRepository;

    public GetUserQueryHandler(IUserContext userContext, IUserRepository userRepository)
    {

        _userContext = userContext;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        string id = _userContext.UserId;
        User user = await _userRepository.FindByIdAsync(id);
        return Result.Success(user);
    }
}
