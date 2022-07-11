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
}
