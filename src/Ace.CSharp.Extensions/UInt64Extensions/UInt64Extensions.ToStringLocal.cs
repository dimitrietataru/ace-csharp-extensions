namespace Ace.CSharp.Extensions;

public static partial class UInt64Extensions
{
    public static string ToStringLocal(this ulong value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this ulong value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
