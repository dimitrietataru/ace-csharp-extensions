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
}
