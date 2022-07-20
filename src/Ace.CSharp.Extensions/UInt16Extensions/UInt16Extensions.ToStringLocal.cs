namespace Ace.CSharp.Extensions;

public static partial class UInt16Extensions
{
    public static string ToStringLocal(this ushort value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this ushort value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
