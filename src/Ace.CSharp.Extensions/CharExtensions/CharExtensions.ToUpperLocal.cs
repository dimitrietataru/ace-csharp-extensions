namespace Ace.CSharp.Extensions;

public static partial class CharExtensions
{
    public static char ToUpperLocal(this char value)
    {
        return char.ToUpper(value, CultureInfo.CurrentCulture);
    }
}
