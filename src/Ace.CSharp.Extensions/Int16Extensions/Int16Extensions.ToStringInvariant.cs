namespace Ace.CSharp.Extensions;

public static partial class Int16Extensions
{
    public static string ToStringInvariant(this short value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this short value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
