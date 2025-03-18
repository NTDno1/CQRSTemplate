using Ardalis.SmartEnum;

namespace ERP.Share.Extensions;
public static class EnumExtentions
{
    public static bool IsValidSmartEnumValue<TEnum>(string value)
        where TEnum : SmartEnum<TEnum, string>
    {
        return SmartEnum<TEnum, string>.TryFromValue(value, out _);
    }
}
