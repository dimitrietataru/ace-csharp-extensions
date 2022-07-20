namespace Ace.CSharp.Extensions;

public static partial class Int32Extensions
{
    public static string ToStringInvariant(this int value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this int value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
