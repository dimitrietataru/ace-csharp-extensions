namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static byte? ToNullableByteInvariant(this object? value)
    {
        return value.ToNullableByte(CultureInfo.InvariantCulture);
    }
}
