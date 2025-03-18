using ERP.Application.UseCases.Users.GetUser;
using FluentValidation;

namespace ERP.Application.UseCases.Users.CreateUser;
public class GetUserValidator : AbstractValidator<GetUserQuery>
{
    public GetUserValidator()
    {

    }
}
