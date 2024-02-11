namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static float? ToNullableSingleLocal(this object? value)
    {
        return value.ToNullableSingle(CultureInfo.CurrentCulture);
    }
}
