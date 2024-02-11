namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static decimal? ToNullableDecimalInvariant(this object? value)
    {
        return value.ToNullableDecimal(CultureInfo.InvariantCulture);
    }
}
