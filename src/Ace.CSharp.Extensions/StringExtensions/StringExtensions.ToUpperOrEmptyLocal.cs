namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string ToUpperOrEmptyLocal(this string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        return value.ToUpper(CultureInfo.CurrentCulture);
    }
}
