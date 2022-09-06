namespace Ace.CSharp.Extensions;

public static partial class SByteExtensions
{
    public static string ToStringInvariant(this sbyte @this)
    {
        return @this.ToString(CultureInfo.InvariantCulture);
    }

    public static string ToStringInvariant(this sbyte @this, string? format)
    {
        return @this.ToString(format, CultureInfo.InvariantCulture);
    }
}
