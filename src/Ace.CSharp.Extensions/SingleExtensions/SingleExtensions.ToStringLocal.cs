namespace Ace.CSharp.Extensions;

public static partial class SingleExtensions
{
    public static string ToStringLocal(this float value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this float value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
