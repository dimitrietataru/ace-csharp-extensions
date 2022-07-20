namespace Ace.CSharp.Extensions;

public static partial class Int64Extensions
{
    public static string ToStringInvariant(this long value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this long value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
