namespace Ace.CSharp.Extensions;

public static partial class Int64Extensions
{
    public static string ToStringInvariant(this long @this)
    {
        return @this.ToString(CultureInfo.InvariantCulture);
    }

    public static string ToStringInvariant(this long @this, string? format)
    {
        return @this.ToString(format, CultureInfo.InvariantCulture);
    }
}
