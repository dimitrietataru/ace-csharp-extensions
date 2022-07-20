namespace Ace.CSharp.Extensions;

public static partial class DoubleExtensions
{
    public static string ToStringLocal(this double value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this double value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
