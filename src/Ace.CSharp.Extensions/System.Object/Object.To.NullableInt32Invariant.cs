namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static int? ToNullableInt32Invariant(this object? value)
    {
        return value.ToNullableInt32(CultureInfo.InvariantCulture);
    }

    public static int? ToNullableIntInvariant(this object? value)
    {
        return value.ToNullableInt32Invariant();
    }
}
