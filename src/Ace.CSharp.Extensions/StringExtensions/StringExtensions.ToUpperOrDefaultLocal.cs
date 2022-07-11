namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string ToUpperOrDefaultLocal(this string? value, string @default = "")
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return @default;
        }

        return value.ToUpper(CultureInfo.CurrentCulture);
    }
}
