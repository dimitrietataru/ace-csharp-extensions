namespace Ace.CSharp.Extensions;

public static partial class BooleanExtensions
{
    public static string ToStringLocal(this bool value)
    {
        string result = value.ToString(CultureInfo.CurrentCulture);

        return result;
    }
}
