namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static short? ToNullableInt16Invariant(this object? value)
    {
        return value.ToNullableInt16(CultureInfo.InvariantCulture);
    }
}
