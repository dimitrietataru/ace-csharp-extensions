namespace Ace.CSharp.Extensions;

public static partial class SByteExtensions
{
    public static string ToStringLocal(this sbyte value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this sbyte value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
