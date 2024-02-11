namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static uint? ToNullableUInt32Local(this object? value)
    {
        return value.ToNullableUInt32(CultureInfo.CurrentCulture);
    }

    public static uint? ToNullableUIntLocal(this object? value)
    {
        return value.ToNullableUInt32Local();
    }
}
