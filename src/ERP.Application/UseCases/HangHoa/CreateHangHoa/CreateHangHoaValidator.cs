using ERP.Domain.Entities.PURC.HangHoa;
using ERP.Share.Extensions;
using FluentValidation;

namespace ERP.Application.UseCases.HangHoa.CreateHangHoa;
public class CreateHangHoaValidator : AbstractValidator<CreateHangHoaCommand>
{
    public CreateHangHoaValidator()
    {
        RuleFor(x => x.MangKinhDoanh)
            .Must(EnumExtentions.IsValidSmartEnumValue<MangKinhDoanh>)
            .WithMessage("Mảng kinh doanh không phù hợp!");
    }
}
