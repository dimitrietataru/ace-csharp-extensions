namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float? ToNullableSingleLocal(this string? value)
    {
        return value.ToNullableSingle(CultureInfo.CurrentCulture);
    }
}
