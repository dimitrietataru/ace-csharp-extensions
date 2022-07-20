namespace Ace.CSharp.Extensions;

public static partial class BooleanExtensions
{
    public static string ToStringInvariant(this bool value)
    {
        string result = value.ToString(CultureInfo.InvariantCulture);

        return result;
    }
}
