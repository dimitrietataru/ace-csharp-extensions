namespace Ace.CSharp.Extensions;

public static partial class DecimalExtensions
{
    public static string ToStringInvariant(this decimal value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this decimal value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
