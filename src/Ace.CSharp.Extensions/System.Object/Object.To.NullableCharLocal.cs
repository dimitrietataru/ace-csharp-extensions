namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static char? ToNullableCharLocal(this object? value)
    {
        return value.ToNullableChar(CultureInfo.CurrentCulture);
    }
}
