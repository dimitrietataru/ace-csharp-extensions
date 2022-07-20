namespace Ace.CSharp.Extensions;

public static partial class DecimalExtensions
{
    public static string ToStringLocal(this decimal value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this decimal value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
