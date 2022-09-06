namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ContainsOrdinal(this string? @this, char lookupValue)
    {
        if (string.IsNullOrEmpty(@this))
        {
            return false;
        }

        return @this.Contains(lookupValue, StringComparison.Ordinal);
    }

    public static bool ContainsOrdinal(this string? @this, string lookupValue)
    {
        if (string.IsNullOrEmpty(@this))
        {
            return false;
        }

        return @this.Contains(lookupValue, StringComparison.Ordinal);
    }
}
