namespace Ace.CSharp.Extensions;

public static partial class DoubleExtensions
{
    public static string ToStringInvariant(this double value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }

    public static string ToStringInvariant(this double value, string? format)
    {
        string result = value.ToString(format, CultureInfo.InvariantCulture);

        return result;
    }
}
