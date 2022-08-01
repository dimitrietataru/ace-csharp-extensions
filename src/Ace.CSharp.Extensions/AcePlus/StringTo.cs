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
        return StringExtensions.ToCharOrDefault(value, provider, defaultValue);
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

    public static int Int32(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToInt32(value, provider);
    }

    public static int Int32OrDefault(string? value, IFormatProvider? provider, int defaultValue = default)
    {
        return StringExtensions.ToInt32OrDefault(value, provider, defaultValue);
    }

    public static int Int(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToInt32(value, provider);
    }

    public static int IntOrDefault(string? value, IFormatProvider? provider, int defaultValue = default)
    {
        return StringExtensions.ToInt32OrDefault(value, provider, defaultValue);
    }

    public static int Int32Invariant(string? value)
    {
        return StringExtensions.ToInt32Invariant(value);
    }

    public static int Int32OrDefaultInvariant(string? value, int defaultValue = default)
    {
        return StringExtensions.ToInt32OrDefaultInvariant(value, defaultValue);
    }

    public static int IntInvariant(string? value)
    {
        return StringExtensions.ToInt32Invariant(value);
    }

    public static int IntOrDefaultInvariant(string? value, int defaultValue = default)
    {
        return StringExtensions.ToInt32OrDefaultInvariant(value, defaultValue);
    }

    public static int Int32Local(string? value)
    {
        return StringExtensions.ToInt32Local(value);
    }

    public static int Int32OrDefaultLocal(string? value, int defaultValue = default)
    {
        return StringExtensions.ToInt32OrDefaultLocal(value, defaultValue);
    }

    public static int IntLocal(string? value)
    {
        return StringExtensions.ToInt32Local(value);
    }

    public static int IntOrDefaultLocal(string? value, int defaultValue = default)
    {
        return StringExtensions.ToInt32OrDefaultLocal(value, defaultValue);
    }

    public static long Int64(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToInt64(value, provider);
    }

    public static long Int64OrDefault(string? value, IFormatProvider? provider, long defaultValue = default)
    {
        return StringExtensions.ToInt64OrDefault(value, provider, defaultValue);
    }

    public static long Long(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToInt64(value, provider);
    }

    public static long LongOrDefault(string? value, IFormatProvider? provider, long defaultValue = default)
    {
        return StringExtensions.ToInt64OrDefault(value, provider, defaultValue);
    }

    public static long Int64Invariant(string? value)
    {
        return StringExtensions.ToInt64Invariant(value);
    }

    public static long Int64OrDefaultInvariant(string? value, long defaultValue = default)
    {
        return StringExtensions.ToInt64OrDefaultInvariant(value, defaultValue);
    }

    public static long LongLocalInvariant(string? value)
    {
        return StringExtensions.ToInt64Invariant(value);
    }

    public static long LongOrDefaultInvariant(string? value, long defaultValue = default)
    {
        return StringExtensions.ToInt64OrDefaultInvariant(value, defaultValue);
    }

    public static long Int64Local(string? value)
    {
        return StringExtensions.ToInt64Local(value);
    }

    public static long Int64OrDefaultLocal(string? value, long defaultValue = default)
    {
        return StringExtensions.ToInt64OrDefaultLocal(value, defaultValue);
    }

    public static long LongLocal(string? value)
    {
        return StringExtensions.ToInt64Local(value);
    }

    public static long LongOrDefaultLocal(string? value, long defaultValue = default)
    {
        return StringExtensions.ToInt64OrDefaultLocal(value, defaultValue);
    }

    public static sbyte SByte(string value, IFormatProvider? provider)
    {
        return StringExtensions.ToSByte(value, provider);
    }

    public static sbyte SByteOrDefault(string value, IFormatProvider? provider, sbyte defaultValue = default)
    {
        return StringExtensions.ToSByteOrDefault(value, provider, defaultValue);
    }

    public static sbyte SByteInvariant(string value)
    {
        return StringExtensions.ToSByteInvariant(value);
    }

    public static sbyte SByteOrDefaultInvariant(string value, sbyte defaultValue = default)
    {
        return StringExtensions.ToSByteOrDefaultInvariant(value, defaultValue);
    }

    public static sbyte SByteLocal(string value)
    {
        return StringExtensions.ToSByteLocal(value);
    }

    public static sbyte SByteOrDefaultLocal(string value, sbyte defaultValue = default)
    {
        return StringExtensions.ToSByteOrDefaultLocal(value, defaultValue);
    }

    public static float Single(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToSingle(value, provider);
    }

    public static float SingleOrDefault(string? value, IFormatProvider? provider, float defaultValue = default)
    {
        return StringExtensions.ToSingleOrDefault(value, provider, defaultValue);
    }

    public static float Float(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToSingle(value, provider);
    }

    public static float FloatOrDefault(string? value, IFormatProvider? provider, float defaultValue = default)
    {
        return StringExtensions.ToSingleOrDefault(value, provider, defaultValue);
    }

    public static float SingleInvariant(string? value)
    {
        return StringExtensions.ToSingleInvariant(value);
    }

    public static float SingleOrDefaultInvariant(string? value, float defaultValue = default)
    {
        return StringExtensions.ToSingleOrDefaultInvariant(value, defaultValue);
    }

    public static float FloatInvariant(string? value)
    {
        return StringExtensions.ToSingleInvariant(value);
    }

    public static float FloatOrDefaultInvariant(string? value, float defaultValue = default)
    {
        return StringExtensions.ToSingleOrDefaultInvariant(value, defaultValue);
    }

    public static float SingleLocal(string? value)
    {
        return StringExtensions.ToSingleLocal(value);
    }

    public static float SingleOrDefaultLocal(string? value, float defaultValue = default)
    {
        return StringExtensions.ToSingleOrDefaultLocal(value, defaultValue);
    }

    public static float FloatLocal(string? value)
    {
        return StringExtensions.ToSingleLocal(value);
    }

    public static float FloatOrDefaultLocal(string? value, float defaultValue = default)
    {
        return StringExtensions.ToSingleOrDefaultLocal(value, defaultValue);
    }

    public static ushort UInt16(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToUInt16(value, provider);
    }

    public static ushort UInt16OrDefault(string? value, IFormatProvider? provider, ushort defaultValue = default)
    {
        return StringExtensions.ToUInt16OrDefault(value, provider, defaultValue);
    }

    public static ushort UInt16Invariant(string? value)
    {
        return StringExtensions.ToUInt16Invariant(value);
    }

    public static ushort UInt16OrDefaultInvariant(string? value, ushort defaultValue = default)
    {
        return StringExtensions.ToUInt16OrDefaultInvariant(value, defaultValue);
    }

    public static ushort UInt16Local(string? value)
    {
        return StringExtensions.ToUInt16Local(value);
    }

    public static ushort UInt16OrDefaultLocal(string? value, ushort defaultValue = default)
    {
        return StringExtensions.ToUInt16OrDefaultLocal(value, defaultValue);
    }

    public static uint UInt32(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToUInt32(value, provider);
    }

    public static uint UInt32OrDefault(string? value, IFormatProvider? provider, uint defaultValue = default)
    {
        return StringExtensions.ToUInt32OrDefault(value, provider, defaultValue);
    }

    public static uint UInt(string? value, IFormatProvider? provider)
    {
        return StringExtensions.ToUInt32(value, provider);
    }

    public static uint UIntOrDefault(string? value, IFormatProvider? provider, uint defaultValue = default)
    {
        return StringExtensions.ToUInt32OrDefault(value, provider, defaultValue);
    }

    public static uint UInt32Invariant(string? value)
    {
        return StringExtensions.ToUInt32Invariant(value);
    }

    public static uint UInt32OrDefaultInvariant(string? value, uint defaultValue = default)
    {
        return StringExtensions.ToUInt32OrDefaultInvariant(value, defaultValue);
    }

    public static uint UIntInvariant(string? value)
    {
        return StringExtensions.ToUInt32Invariant(value);
    }

    public static uint UIntOrDefaultInvariant(string? value, uint defaultValue = default)
    {
        return StringExtensions.ToUInt32OrDefaultInvariant(value, defaultValue);
    }

    public static uint UInt32Local(string? value)
    {
        return StringExtensions.ToUInt32Local(value);
    }

    public static uint UInt32OrDefaultLocal(string? value, uint defaultValue = default)
    {
        return StringExtensions.ToUInt32OrDefaultLocal(value, defaultValue);
    }

    public static uint UIntLocal(string? value)
    {
        return StringExtensions.ToUInt32Local(value);
    }

    public static uint UIntOrDefaultLocal(string? value, uint defaultValue = default)
    {
        return StringExtensions.ToUInt32OrDefaultLocal(value, defaultValue);
    }
}
