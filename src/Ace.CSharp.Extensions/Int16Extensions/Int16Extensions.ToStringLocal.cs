namespace Ace.CSharp.Extensions;

public static partial class Int16Extensions
{
    public static string ToStringLocal(this short value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this short value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
