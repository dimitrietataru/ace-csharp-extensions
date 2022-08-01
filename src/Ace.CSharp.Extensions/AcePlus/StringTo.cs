namespace Ace.CSharp.Extensions;

public static class StringTo
{
    public static bool Boolean(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToBoolean(value, provider);
    }

    public static bool BooleanOrDefault(string? value, IFormatProvider? provider, bool defaultValue = default)
    {
        return StringExtensions.ToBooleanOrDefault(value, provider, defaultValue);
    }

    public static bool BooleanInvariant(string? value)
    {
        return StringExtensions.ToBooleanInvariant(value);
    }

    public static bool BooleanOrDefaultInvariant(string? value, bool defaultValue = default)
    {
        return StringExtensions.ToBooleanOrDefaultInvariant(value, defaultValue);
    }

    public static bool BooleanLocal(string? value)
    {
        return StringExtensions.ToBooleanLocal(value);
    }

    public static bool BooleanOrDefaultLocal(string? value, bool defaultValue = default)
    {
        return StringExtensions.ToBooleanOrDefaultLocal(value, defaultValue);
    }

    public static byte Byte(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToByte(value, provider);
    }

    public static byte ByteOrDefault(string? value, IFormatProvider? provider, byte defaultValue = default)
    {
        return StringExtensions.ToByteOrDefault(value, provider, defaultValue);
    }

    public static byte ByteInvariant(string? value)
    {
        return StringExtensions.ToByteInvariant(value);
    }

    public static byte ByteOrDefaultInvariant(string? value, byte defaultValue = default)
    {
        return StringExtensions.ToByteOrDefaultInvariant(value, defaultValue);
    }

    public static byte ByteLocal(string? value)
    {
        return StringExtensions.ToByteLocal(value);
    }

    public static byte ByteOrDefaultLocal(string? value, byte defaultValue = default)
    {
        return StringExtensions.ToByteOrDefaultLocal(value, defaultValue);
    }

    public static char Char(string value, IFormatProvider? provider)
    {
        return StringExtensions.ToChar(value, provider);
    }

    public static char CharOrDefault(string value, IFormatProvider? provider, char defaultValue = default)
    {
        return StringExtensions.ToCharOrDefault(value, provider);
    }

    public static char CharInvariant(string value)
    {
        return StringExtensions.ToCharInvariant(value);
    }

    public static char CharOrDefaultInvariant(string value, char defaultValue = default)
    {
        return StringExtensions.ToCharOrDefaultInvariant(value, defaultValue);
    }

    public static char CharLocal(string value)
    {
        return StringExtensions.ToCharLocal(value);
    }

    public static char CharOrDefaultLocal(string value, char defaultValue = default)
    {
        return StringExtensions.ToCharOrDefaultLocal(value, defaultValue);
    }
}
