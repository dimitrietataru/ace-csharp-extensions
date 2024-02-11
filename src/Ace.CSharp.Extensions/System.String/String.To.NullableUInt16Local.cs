namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static ushort? ToNullableUInt16Local(this string? value)
    {
        return value.ToNullableUInt16(CultureInfo.CurrentCulture);
    }
}
