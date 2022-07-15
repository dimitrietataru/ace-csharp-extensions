namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool ContainsOrdinalIgnoreCase(this string value, char lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return value.Contains(lookupValue, StringComparison.OrdinalIgnoreCase);
    }

    public static bool ContainsOrdinalIgnoreCase(this string value, string lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return value.Contains(lookupValue, StringComparison.OrdinalIgnoreCase);
    }
}
