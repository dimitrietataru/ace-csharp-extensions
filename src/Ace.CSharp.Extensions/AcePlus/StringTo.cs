namespace Ace.CSharp.Extensions;

public static class StringTo
{
    public static bool Boolean(string? value, IFormatProvider? provider)
    {
        return value.ToBoolean(provider);
    }

    public static bool BooleanOrDefault(string? value, IFormatProvider? provider, bool defaultValue = default)
    {
        return value.ToBooleanOrDefault(provider, defaultValue);
    }

    public static bool BooleanInvariant(string? value)
    {
        return value.ToBooleanInvariant();
    }

    public static bool BooleanOrDefaultInvariant(string? value, bool defaultValue = default)
    {
        return value.ToBooleanOrDefaultInvariant(defaultValue);
    }

    public static bool BooleanLocal(string? value)
    {
        return value.ToBooleanLocal();
    }

    public static bool BooleanOrDefaultLocal(string? value, bool defaultValue = default)
    {
        return value.ToBooleanOrDefaultLocal(defaultValue);
    }

    public static byte Byte(string? value, IFormatProvider? provider)
    {
        return value.ToByte(provider);
    }

    public static byte ByteOrDefault(string? value, IFormatProvider? provider, byte defaultValue = default)
    {
        return value.ToByteOrDefault(provider, defaultValue);
    }

    public static byte ByteInvariant(string? value)
    {
        return value.ToByteInvariant();
    }

    public static byte ByteOrDefaultInvariant(string? value, byte defaultValue = default)
    {
        return value.ToByteOrDefaultInvariant(defaultValue);
    }

    public static byte ByteLocal(string? value)
    {
        return value.ToByteLocal();
    }

    public static byte ByteOrDefaultLocal(string? value, byte defaultValue = default)
    {
        return value.ToByteOrDefaultLocal(defaultValue);
    }
}
