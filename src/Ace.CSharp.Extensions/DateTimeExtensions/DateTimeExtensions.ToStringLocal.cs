namespace Ace.CSharp.Extensions;

public static partial class DateTimeExtensions
{
    public static string ToStringLocal(this DateTime dateTime)
    {
        string result = dateTime.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this DateTime dateTime, string? format)
    {
        string result = dateTime.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
