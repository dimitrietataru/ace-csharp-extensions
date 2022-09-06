namespace Ace.CSharp.Extensions;

public static partial class DecimalExtensions
{
    public static string ToStringLocal(this decimal @this)
    {
        return @this.ToString(CultureInfo.CurrentCulture);
    }

    public static string ToStringLocal(this decimal @this, string? format)
    {
        return @this.ToString(format, CultureInfo.CurrentCulture);
    }
}
