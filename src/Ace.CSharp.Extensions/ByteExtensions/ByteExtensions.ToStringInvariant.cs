namespace Ace.CSharp.Extensions;

public static partial class ByteExtensions
{
    public static string ToStringInvariant(this byte value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this byte value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
