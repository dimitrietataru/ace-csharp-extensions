namespace Ace.CSharp.Extensions;

public static partial class CharExtensions
{
    public static string ToStringLocal(this char value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }
}
