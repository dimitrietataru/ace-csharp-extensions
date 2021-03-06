namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool EqualsOrdinalIgnoreCase(this string value, string? other)
    {
        return string.Equals(value, other, StringComparison.OrdinalIgnoreCase);
    }
}
