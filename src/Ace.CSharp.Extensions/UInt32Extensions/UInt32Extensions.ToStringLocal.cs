namespace Ace.CSharp.Extensions;

public static partial class UInt32Extensions
{
    public static string ToStringLocal(this uint value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this uint value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
