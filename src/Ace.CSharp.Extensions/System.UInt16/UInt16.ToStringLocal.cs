namespace Ace.CSharp.Extensions;

public static partial class UInt16Extensions
{
    public static string ToStringLocal(this ushort @this)
    {
        return @this.ToString(CultureInfo.CurrentCulture);
    }

    public static string ToStringLocal(this ushort @this, string? format)
    {
        return @this.ToString(format, CultureInfo.CurrentCulture);
    }
}
