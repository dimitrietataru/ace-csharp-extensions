namespace Ace.CSharp.Extensions;

public static partial class Int32Extensions
{
    public static string ToStringLocal(this int @this)
    {
        return @this.ToString(CultureInfo.CurrentCulture);
    }

    public static string ToStringLocal(this int @this, string? format)
    {
        return @this.ToString(format, CultureInfo.CurrentCulture);
    }
}
