namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ushort? ToNullableUInt16Local(this object? value)
    {
        return value.ToNullableUInt16(CultureInfo.CurrentCulture);
    }
}
