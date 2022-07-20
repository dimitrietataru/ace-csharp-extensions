namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static long ToInt64Invariant(this object? value)
    {
        return ToInt64(value, CultureInfo.InvariantCulture);
    }

    public static long ToInt64OrDefaultInvariant(this object? value, long defaultValue = default)
    {
        return ToInt64OrDefault(value, CultureInfo.InvariantCulture, defaultValue);
    }

    public static bool TryConvertToInt64Invariant(this object? value, out long result)
    {
        return TryConvertToInt64(value, CultureInfo.InvariantCulture, out result);
    }

    public static long ToLongLocalInvariant(this object? value)
    {
        return ToInt64Invariant(value);
    }

    public static long ToLongOrDefaultInvariant(this object? value, long defaultValue = default)
    {
        return ToInt64OrDefaultInvariant(value, defaultValue);
    }

    public static bool TryConvertToLongInvariant(this object? value, out long result)
    {
        return TryConvertToInt64Invariant(value, out result);
    }
}
