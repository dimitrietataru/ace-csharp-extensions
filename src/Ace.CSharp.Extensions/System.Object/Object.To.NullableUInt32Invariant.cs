namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static uint? ToNullableUInt32Invariant(this object? value)
    {
        return value.ToNullableUInt32(CultureInfo.InvariantCulture);
    }

    public static uint? ToNullableUIntInvariant(this object? value)
    {
        return value.ToNullableUInt32Invariant();
    }
}
