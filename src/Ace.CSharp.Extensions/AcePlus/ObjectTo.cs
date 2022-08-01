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

    public static char Char(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToChar(value, provider);
    }

    public static char CharOrDefault(object? value, IFormatProvider? provider, char defaultValue = default)
    {
        return ObjectExtensions.ToCharOrDefault(value, provider, defaultValue);
    }

    public static char CharInvariant(object? value)
    {
        return ObjectExtensions.ToCharInvariant(value);
    }

    public static char CharOrDefaultInvariant(object? value, char defaultValue = default)
    {
        return ObjectExtensions.ToCharOrDefaultInvariant(value, defaultValue);
    }

    public static char CharLocal(object? value)
    {
        return ObjectExtensions.ToCharLocal(value);
    }

    public static char CharOrDefaultLocal(object? value, char defaultValue = default)
    {
        return ObjectExtensions.ToCharOrDefaultLocal(value, defaultValue);
    }

    public static DateTime DateTime(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToDateTime(value, provider);
    }

    public static DateTime DateTimeOrDefault(object? value, IFormatProvider? provider, DateTime defaultValue = default)
    {
        return ObjectExtensions.ToDateTimeOrDefault(value, provider, defaultValue);
    }

    public static DateTime DateTimeInvariant(object? value)
    {
        return ObjectExtensions.ToDateTimeInvariant(value);
    }

    public static DateTime DateTimeOrDefaultInvariant(object? value, DateTime defaultValue = default)
    {
        return ObjectExtensions.ToDateTimeOrDefaultInvariant(value, defaultValue);
    }

    public static DateTime DateTimeLocal(object? value)
    {
        return ObjectExtensions.ToDateTimeLocal(value);
    }

    public static DateTime DateTimeOrDefaultLocal(object? value, DateTime defaultValue = default)
    {
        return ObjectExtensions.ToDateTimeOrDefaultLocal(value, defaultValue);
    }
}
