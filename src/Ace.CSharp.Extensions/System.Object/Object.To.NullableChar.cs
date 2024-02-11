namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static char? ToNullableChar(this object? value, IFormatProvider? provider)
    {
        return value == null
            ? null
            : value.TryConvertToChar(provider, out char result)
                ? result
                : null;
    }
}
