using FluentValidation;

namespace ERP.Application.UseCases.WhChuyenKhos.GetWhChuyenKho;
public class GetChuyenKhoValidator : AbstractValidator<GetWhChuyenKhoQuery>
{
    public GetChuyenKhoValidator()
    {
        RuleFor(x => x.idChuyenKho)
       .Must(x => !string.IsNullOrWhiteSpace(x))
       .WithMessage("Id Không được để trống");
    }
}
