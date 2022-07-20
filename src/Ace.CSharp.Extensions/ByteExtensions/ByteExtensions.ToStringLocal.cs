namespace Ace.CSharp.Extensions;

public static partial class ByteExtensions
{
    public static string ToStringLocal(this byte value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }

    public static string ToStringLocal(this byte value, string? format)
    {
        string result = value.ToString(format, CultureInfo.CurrentCulture);

        return result;
    }
}
