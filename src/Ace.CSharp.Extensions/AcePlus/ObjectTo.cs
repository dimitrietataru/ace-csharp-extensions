namespace Ace.CSharp.Extensions;

public static class ObjectTo
{
    public static bool Boolean(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToBoolean(value, provider);
    }

    public static bool BooleanOrDefault(object? value, IFormatProvider? provider, bool defaultValue = default)
    {
        return ObjectExtensions.ToBooleanOrDefault(value, provider, defaultValue);
    }

    public static bool BooleanInvariant(object? value)
    {
        return ObjectExtensions.ToBooleanInvariant(value);
    }

    public static bool BooleanOrDefaultInvariant(object? value, bool defaultValue = default)
    {
        return ObjectExtensions.ToBooleanOrDefaultInvariant(value, defaultValue);
    }

    public static bool BooleanLocal(object? value)
    {
        return ObjectExtensions.ToBooleanLocal(value);
    }

    public static bool BooleanOrDefaultLocal(object? value, bool defaultValue = default)
    {
        return ObjectExtensions.ToBooleanOrDefaultLocal(value, defaultValue);
    }

    public static byte Byte(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToByte(value, provider);
    }

    public static byte ByteOrDefault(object? value, IFormatProvider? provider, byte defaultValue = default)
    {
        return ObjectExtensions.ToByteOrDefault(value, provider, defaultValue);
    }

    public static byte ByteInvariant(object? value)
    {
        return ObjectExtensions.ToByteInvariant(value);
    }

    public static byte ByteOrDefaultInvariant(object? value, byte defaultValue = default)
    {
        return ObjectExtensions.ToByteOrDefaultInvariant(value, defaultValue);
    }

    public static byte ByteLocal(object? value)
    {
        return ObjectExtensions.ToByteLocal(value);
    }

    public static byte ByteOrDefaultLocal(object? value, byte defaultValue = default)
    {
        return ObjectExtensions.ToByteOrDefaultLocal(value, defaultValue);
    }
}
