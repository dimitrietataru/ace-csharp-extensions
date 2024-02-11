namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double? ToNullableDoubleInvariant(this string? value)
    {
        return value.ToNullableDouble(CultureInfo.InvariantCulture);
    }
}
