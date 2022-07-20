namespace Ace.CSharp.Extensions;

public static partial class UInt16Extensions
{
    public static string ToStringInvariant(this ushort value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this ushort value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
