namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string ToLowerOrEmptyLocal(this string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        return value.ToLower(CultureInfo.CurrentCulture);
    }
}
