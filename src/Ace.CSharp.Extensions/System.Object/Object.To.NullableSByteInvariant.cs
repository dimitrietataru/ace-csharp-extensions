namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static sbyte? ToNullableSByteInvariant(this object? value)
    {
        return value.ToNullableSByte(CultureInfo.InvariantCulture);
    }
}
