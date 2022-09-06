namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ContainsOrdinalIgnoreCase(this string? @this, char lookupValue)
    {
        if (string.IsNullOrEmpty(@this))
        {
            return false;
        }

        return @this.Contains(lookupValue, StringComparison.OrdinalIgnoreCase);
    }

    public static bool ContainsOrdinalIgnoreCase(this string? @this, string lookupValue)
    {
        if (string.IsNullOrEmpty(@this))
        {
            return false;
        }

        return @this.Contains(lookupValue, StringComparison.OrdinalIgnoreCase);
    }
}
