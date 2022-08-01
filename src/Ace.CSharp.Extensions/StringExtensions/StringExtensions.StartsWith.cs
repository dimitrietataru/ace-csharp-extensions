namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool StartsWithOrdinal(this string value, string lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return value.StartsWith(lookupValue, StringComparison.Ordinal);
    }

    public static bool StartsWithOrdinalIgnoreCase(this string value, string lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return value.StartsWith(lookupValue, StringComparison.OrdinalIgnoreCase);
    }
}
