namespace Ace.CSharp.Extensions;

public static partial class SByteExtensions
{
    public static string ToStringInvariant(this sbyte value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this sbyte value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
