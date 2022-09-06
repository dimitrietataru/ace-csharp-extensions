namespace Ace.CSharp.Extensions;

public static partial class ByteExtensions
{
    public static string ToStringInvariant(this byte @this)
    {
        return @this.ToString(CultureInfo.InvariantCulture);
    }

    public static string ToStringInvariant(this byte @this, string? format)
    {
        return @this.ToString(format, CultureInfo.InvariantCulture);
    }
}
