namespace ERP.Application.Abstractions.Authentication;
public interface IUserContext
{
    string UserId { get; }

    string UserName { get; }
}

