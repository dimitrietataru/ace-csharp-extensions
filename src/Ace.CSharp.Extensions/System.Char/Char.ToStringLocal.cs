namespace Ace.CSharp.Extensions;

public static partial class CharExtensions
{
    public static string ToStringLocal(this char @this)
    {
        return @this.ToString(CultureInfo.CurrentCulture);
    }
}
