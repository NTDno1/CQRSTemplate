using ERP.Domain.Entities.System.Users;
using FluentValidation;

namespace ERP.Application.UseCases.HangHoa.CreateNhomHang;

public class CreateNhomHangValidator : AbstractValidator<CreateNhomHangCommand>
{
    private readonly IUserRepository _userRepository;

    public CreateNhomHangValidator(IUserRepository userRepository)
    {
        _userRepository = userRepository;

        RuleFor(x => x.leader)
           .MustAsync(CheckExist)
           .When(x => !string.IsNullOrEmpty(x.muaHangPhuTrach))
           .WithMessage("Username của leader không tồn tại!");

    }

    private async Task<bool> CheckExist(string name, CancellationToken cancellation)
    {
        var userExist = await _userRepository.FindByIdAsync(name);
        if (userExist != null)
        {
            return true;
        }
        return false;
    }

}
