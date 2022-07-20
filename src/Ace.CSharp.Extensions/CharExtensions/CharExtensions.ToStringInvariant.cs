namespace Ace.CSharp.Extensions;

public static partial class CharExtensions
{
    public static string ToStringInvariant(this char value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }
}
