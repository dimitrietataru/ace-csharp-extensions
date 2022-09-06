namespace Ace.CSharp.Extensions;

public static partial class BooleanExtensions
{
    public static string ToStringInvariant(this bool @this)
    {
        return @this.ToString(CultureInfo.InvariantCulture);
    }
}
