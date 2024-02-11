namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool? ToNullableBooleanInvariant(this string? value)
    {
        return value.ToNullableBoolean(CultureInfo.InvariantCulture);
    }
}
