namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static short? ToNullableInt16Local(this string? value)
    {
        return value.ToNullableInt16(CultureInfo.CurrentCulture);
    }
}
