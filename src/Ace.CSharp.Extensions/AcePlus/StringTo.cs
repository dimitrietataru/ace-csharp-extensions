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

    public static DateTime DateTime(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToDateTime(value, provider);
    }

    public static DateTime DateTimeOrDefault(string? value, IFormatProvider? provider, DateTime defaultValue = default)
    {
        return StringExtensions.ToDateTimeOrDefault(value, provider, defaultValue);
    }

    public static DateTime DateTimeInvariant(string? value)
    {
        return StringExtensions.ToDateTimeInvariant(value);
    }

    public static DateTime DateTimeOrDefaultInvariant(string? value, DateTime defaultValue = default)
    {
        return StringExtensions.ToDateTimeOrDefaultInvariant(value, defaultValue);
    }

    public static DateTime DateTimeLocal(string? value)
    {
        return StringExtensions.ToDateTimeLocal(value);
    }

    public static DateTime DateTimeOrDefaultLocal(string? value, DateTime defaultValue = default)
    {
        return StringExtensions.ToDateTimeOrDefaultLocal(value, defaultValue);
    }

    public static decimal Decimal(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToDecimal(value, provider);
    }

    public static decimal DecimalOrDefault(string? value, IFormatProvider? provider, decimal defaultValue = default)
    {
        return StringExtensions.ToDecimalOrDefault(value, provider, defaultValue);
    }

    public static decimal DecimalInvariant(string? value)
    {
        return StringExtensions.ToDecimalInvariant(value);
    }

    public static decimal DecimalOrDefaultInvariant(string? value, decimal defaultValue = default)
    {
        return StringExtensions.ToDecimalOrDefaultInvariant(value, defaultValue);
    }

    public static decimal DecimalLocal(string? value)
    {
        return StringExtensions.ToDecimalLocal(value);
    }

    public static decimal DecimalOrDefaultLocal(string? value, decimal defaultValue = default)
    {
        return StringExtensions.ToDecimalOrDefaultLocal(value, defaultValue);
    }

    public static double Double(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToDouble(value, provider);
    }

    public static double DoubleOrDefault(string? value, IFormatProvider? provider, double defaultValue = default)
    {
        return StringExtensions.ToDoubleOrDefault(value, provider, defaultValue);
    }

    public static double DoubleInvariant(string? value)
    {
        return StringExtensions.ToDoubleInvariant(value);
    }

    public static double DoubleOrDefaultInvariant(string? value, double defaultValue = default)
    {
        return StringExtensions.ToDoubleOrDefaultInvariant(value, defaultValue);
    }

    public static double DoubleLocal(string? value)
    {
        return StringExtensions.ToDoubleLocal(value);
    }

    public static double DoubleOrDefaultLocal(string? value, double defaultValue = default)
    {
        return StringExtensions.ToDoubleOrDefaultLocal(value, defaultValue);
    }

    public static short Int16(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToInt16(value, provider);
    }

    public static short Int16OrDefault(string? value, IFormatProvider? provider, short defaultValue = default)
    {
        return StringExtensions.ToInt16OrDefault(value, provider, defaultValue);
    }

    public static short Int16Invariant(string? value)
    {
        return StringExtensions.ToInt16Invariant(value);
    }

    public static short Int16OrDefaultInvariant(string? value, short defaultValue = default)
    {
        return StringExtensions.ToInt16OrDefaultInvariant(value, defaultValue);
    }

    public static short Int16Local(string? value)
    {
        return StringExtensions.ToInt16Local(value);
    }

    public static short Int16OrDefaultLocal(string? value, short defaultValue = default)
    {
        return StringExtensions.ToInt16OrDefaultLocal(value, defaultValue);
    }
}
