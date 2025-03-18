using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ERP.Share.Extensions;
public static class EfCoreConverters
{
    public static readonly ValueConverter<Ulid, string> UlidToGuidConverter = new ValueConverter<Ulid, string>(
           ulid => ulid.ToString(),
           ulidString => Ulid.Parse(ulidString));
}
