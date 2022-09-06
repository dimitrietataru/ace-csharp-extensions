namespace Ace.CSharp.Extensions;

public static partial class Int32Extensions
{
    public static string ToStringInvariant(this int @this)
    {
        return @this.ToString(CultureInfo.InvariantCulture);
    }

    public static string ToStringInvariant(this int @this, string? format)
    {
        return @this.ToString(format, CultureInfo.InvariantCulture);
    }
}
