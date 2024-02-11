namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static ulong? ToNullableUInt64Local(this object? value)
    {
        return value.ToNullableUInt64(CultureInfo.CurrentCulture);
    }
}
