namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static long? ToNullableInt64Invariant(this object? value)
    {
        return value.ToNullableInt64(CultureInfo.InvariantCulture);
    }
}
