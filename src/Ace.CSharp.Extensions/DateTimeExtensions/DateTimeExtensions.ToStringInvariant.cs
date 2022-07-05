namespace Ace.CSharp.Extensions;

public static partial class DateTimeExtensions
{
    public static string ToStringInvariant(this DateTime dateTime)
    {
        string result = dateTime.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this DateTime dateTime, string? format)
    {
        string result = dateTime.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
