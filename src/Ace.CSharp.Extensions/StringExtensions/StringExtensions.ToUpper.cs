namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string ToUpperLocal(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        return value.ToUpper(CultureInfo.CurrentCulture);
    }

    public static string ToUpperOrDefaultLocal(this string? value, string defaultValue = "")
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return defaultValue;
        }

        return value.ToUpper(CultureInfo.CurrentCulture);
    }
}
