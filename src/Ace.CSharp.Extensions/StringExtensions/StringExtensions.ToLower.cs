namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string ToLowerLocal(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        return value.ToLower(CultureInfo.CurrentCulture);
    }

    public static string ToLowerOrDefaultLocal(this string? value, string defaultValue = "")
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return defaultValue;
        }

        return value.ToLower(CultureInfo.CurrentCulture);
    }
}
