namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ContainsOrdinal(this string value, char lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return value.Contains(lookupValue, StringComparison.Ordinal);
    }

    public static bool ContainsOrdinal(this string value, string lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return value.Contains(lookupValue, StringComparison.Ordinal);
    }
}
