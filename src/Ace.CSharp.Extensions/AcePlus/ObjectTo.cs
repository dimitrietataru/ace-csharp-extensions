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

    public static decimal Decimal(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToDecimal(value, provider);
    }

    public static decimal DecimalOrDefault(object? value, IFormatProvider? provider, decimal defaultValue = default)
    {
        return ObjectExtensions.ToDecimalOrDefault(value, provider, defaultValue);
    }

    public static decimal DecimalInvariant(object? value)
    {
        return ObjectExtensions.ToDecimalInvariant(value);
    }

    public static decimal DecimalOrDefaultInvariant(object? value, decimal defaultValue = default)
    {
        return ObjectExtensions.ToDecimalOrDefaultInvariant(value, defaultValue);
    }

    public static decimal DecimalLocal(object? value)
    {
        return ObjectExtensions.ToDecimalLocal(value);
    }

    public static decimal DecimalOrDefaultLocal(object? value, decimal defaultValue = default)
    {
        return ObjectExtensions.ToDecimalOrDefaultLocal(value, defaultValue);
    }

    public static double Double(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToDouble(value, provider);
    }

    public static double DoubleOrDefault(object? value, IFormatProvider? provider, double defaultValue = default)
    {
        return ObjectExtensions.ToDoubleOrDefault(value, provider, defaultValue);
    }

    public static double DoubleInvariant(object? value)
    {
        return ObjectExtensions.ToDoubleInvariant(value);
    }

    public static double DoubleOrDefaultInvariant(object? value, double defaultValue = default)
    {
        return ObjectExtensions.ToDoubleOrDefaultInvariant(value, defaultValue);
    }

    public static double DoubleLocal(object? value)
    {
        return ObjectExtensions.ToDoubleLocal(value);
    }

    public static double DoubleOrDefaultLocal(object? value, double defaultValue = default)
    {
        return ObjectExtensions.ToDoubleOrDefaultLocal(value, defaultValue);
    }

    public static short Int16(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt16(value, provider);
    }

    public static short Int16OrDefault(object? value, IFormatProvider? provider, short defaultValue = default)
    {
        return ObjectExtensions.ToInt16OrDefault(value, provider, defaultValue);
    }

    public static short Int16Invariant(object? value)
    {
        return ObjectExtensions.ToInt16Invariant(value);
    }

    public static short Int16OrDefaultInvariant(object? value, short defaultValue = default)
    {
        return ObjectExtensions.ToInt16OrDefaultInvariant(value, defaultValue);
    }

    public static short Int16Local(object? value)
    {
        return ObjectExtensions.ToInt16Local(value);
    }

    public static short Int16OrDefaultLocal(object? value, short defaultValue = default)
    {
        return ObjectExtensions.ToInt16OrDefaultLocal(value, defaultValue);
    }

    public static int Int32(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt32(value, provider);
    }

    public static int Int32OrDefault(object? value, IFormatProvider? provider, int defaultValue = default)
    {
        return ObjectExtensions.ToInt32OrDefault(value, provider, defaultValue);
    }

    public static int Int(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt32(value, provider);
    }

    public static int IntOrDefault(object? value, IFormatProvider? provider, int defaultValue = default)
    {
        return ObjectExtensions.ToInt32OrDefault(value, provider, defaultValue);
    }

    public static int Int32Invariant(object? value)
    {
        return ObjectExtensions.ToInt32Invariant(value);
    }

    public static int Int32OrDefaultInvariant(object? value, int defaultValue = default)
    {
        return ObjectExtensions.ToInt32OrDefaultInvariant(value, defaultValue);
    }

    public static int IntInvariant(object? value)
    {
        return ObjectExtensions.ToInt32Invariant(value);
    }

    public static int IntOrDefaultInvariant(object? value, int defaultValue = default)
    {
        return ObjectExtensions.ToInt32OrDefaultInvariant(value, defaultValue);
    }

    public static int Int32Local(object? value)
    {
        return ObjectExtensions.ToInt32Local(value);
    }

    public static int Int32OrDefaultLocal(object? value, int defaultValue = default)
    {
        return ObjectExtensions.ToInt32OrDefaultLocal(value, defaultValue);
    }

    public static int IntLocal(object? value)
    {
        return ObjectExtensions.ToInt32Local(value);
    }

    public static int IntOrDefaultLocal(object? value, int defaultValue = default)
    {
        return ObjectExtensions.ToInt32OrDefaultLocal(value, defaultValue);
    }

    public static long Int64(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt64(value, provider);
    }

    public static long Int64OrDefault(object? value, IFormatProvider? provider, long defaultValue = default)
    {
        return ObjectExtensions.ToInt64OrDefault(value, provider, defaultValue);
    }

    public static long Long(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt64(value, provider);
    }

    public static long LongOrDefault(object? value, IFormatProvider? provider, long defaultValue = default)
    {
        return ObjectExtensions.ToInt64OrDefault(value, provider, defaultValue);
    }

    public static long Int64Invariant(object? value)
    {
        return ObjectExtensions.ToInt64Invariant(value);
    }

    public static long Int64OrDefaultInvariant(object? value, long defaultValue = default)
    {
        return ObjectExtensions.ToInt64OrDefaultInvariant(value, defaultValue);
    }

    public static long LongLocalInvariant(object? value)
    {
        return ObjectExtensions.ToInt64Invariant(value);
    }

    public static long LongOrDefaultInvariant(object? value, long defaultValue = default)
    {
        return ObjectExtensions.ToInt64OrDefaultInvariant(value, defaultValue);
    }

    public static long Int64Local(object? value)
    {
        return ObjectExtensions.ToInt64Local(value);
    }

    public static long Int64OrDefaultLocal(object? value, long defaultValue = default)
    {
        return ObjectExtensions.ToInt64OrDefaultLocal(value, defaultValue);
    }

    public static long LongLocal(object? value)
    {
        return ObjectExtensions.ToInt64Local(value);
    }

    public static long LongOrDefaultLocal(object? value, long defaultValue = default)
    {
        return ObjectExtensions.ToInt64OrDefaultLocal(value, defaultValue);
    }
}
