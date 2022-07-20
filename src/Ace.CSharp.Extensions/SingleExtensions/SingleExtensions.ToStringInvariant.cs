namespace Ace.CSharp.Extensions;

public static partial class SingleExtensions
{
    public static string ToStringInvariant(this float value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this float value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
