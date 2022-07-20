namespace Ace.CSharp.Extensions;

public static partial class Int64Extensions
{
    public static string ToStringLocal(this long value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this long value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
