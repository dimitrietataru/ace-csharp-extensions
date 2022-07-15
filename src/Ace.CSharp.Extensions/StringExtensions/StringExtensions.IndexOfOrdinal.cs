namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static int IndexOfOrdinal(this string value, char lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return -1;
        }

        return value.IndexOf(lookupValue, StringComparison.Ordinal);
    }

    public static int IndexOfOrdinal(this string value, string lookupValue)
    {
        if (string.IsNullOrEmpty(value))
        {
            return -1;
        }

        return value.IndexOf(lookupValue, StringComparison.Ordinal);
    }

    public static int IndexOfOrdinal(this string value, string lookupValue, int startIndex)
    {
        if (string.IsNullOrEmpty(value))
        {
            return -1;
        }

        return value.IndexOf(lookupValue, startIndex, StringComparison.Ordinal);
    }

    public static int IndexOfOrdinal(this string value, string lookupValue, int startIndex, int count)
    {
        if (string.IsNullOrEmpty(value))
        {
            return -1;
        }

        return value.IndexOf(lookupValue, startIndex, count, StringComparison.Ordinal);
    }
}
