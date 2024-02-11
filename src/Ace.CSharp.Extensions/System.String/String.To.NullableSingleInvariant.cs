namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static float? ToNullableSingleInvariant(this string? value)
    {
        return value.ToNullableSingle(CultureInfo.InvariantCulture);
    }
}
