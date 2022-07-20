namespace Ace.CSharp.Extensions;

public static partial class UInt32Extensions
{
    public static string ToStringInvariant(this uint value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this uint value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
