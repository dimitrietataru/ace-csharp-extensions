namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool? ToNullableBooleanLocal(this string? value)
    {
        return value.ToNullableBoolean(CultureInfo.CurrentCulture);
    }
}
