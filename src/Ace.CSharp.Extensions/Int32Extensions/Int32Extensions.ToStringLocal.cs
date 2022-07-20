namespace Ace.CSharp.Extensions;

public static partial class Int32Extensions
{
    public static string ToStringLocal(this int value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this int value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
