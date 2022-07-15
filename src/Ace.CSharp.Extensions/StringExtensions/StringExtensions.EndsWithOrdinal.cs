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
}
