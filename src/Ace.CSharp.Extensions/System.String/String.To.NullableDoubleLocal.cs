namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static double? ToNullableDoubleLocal(this string? value)
    {
        return value.ToNullableDouble(CultureInfo.CurrentCulture);
    }
}
