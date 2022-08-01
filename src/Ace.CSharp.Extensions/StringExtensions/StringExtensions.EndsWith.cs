namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static bool EndsWithOrdinal(this string value, string lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return value.EndsWith(lookupValue, StringComparison.Ordinal);
    }

    public static bool EndsWithOrdinalIgnoreCase(this string value, string lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return value.EndsWith(lookupValue, StringComparison.OrdinalIgnoreCase);
    }
}
