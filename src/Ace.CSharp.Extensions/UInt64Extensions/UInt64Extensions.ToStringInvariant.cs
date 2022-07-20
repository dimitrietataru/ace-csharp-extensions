namespace Ace.CSharp.Extensions;

public static partial class UInt64Extensions
{
    public static string ToStringInvariant(this ulong value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this ulong value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
