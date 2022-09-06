namespace Ace.CSharp.Extensions;

public static partial class DoubleExtensions
{
    public static string ToStringLocal(this double @this)
    {
        return @this.ToString(CultureInfo.CurrentCulture);
    }

    public static string ToStringLocal(this double @this, string? format)
    {
        return @this.ToString(format, CultureInfo.CurrentCulture);
    }
}
