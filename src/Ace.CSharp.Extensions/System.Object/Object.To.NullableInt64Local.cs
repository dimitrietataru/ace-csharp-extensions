namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static long? ToNullableInt64Local(this object? value)
    {
        return value.ToNullableInt64(CultureInfo.CurrentCulture);
    }
}
