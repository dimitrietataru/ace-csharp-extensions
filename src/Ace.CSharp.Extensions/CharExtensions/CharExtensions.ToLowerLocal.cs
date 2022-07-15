namespace Ace.CSharp.Extensions;

public static partial class CharExtensions
{
    public static char ToLowerLocal(this char value)
    {
        return char.ToLower(value, CultureInfo.CurrentCulture);
    }
}
