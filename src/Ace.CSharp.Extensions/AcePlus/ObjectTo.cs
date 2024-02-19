namespace Ace.CSharp.Extensions;

public static class ObjectTo
{
    public static bool Boolean(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToBoolean(value, provider);
    }

    public static bool BooleanOrDefault(object? value, IFormatProvider? provider, bool @default = default)
    {
        return ObjectExtensions.ToBooleanOrDefault(value, provider, @default);
    }

    public static bool BooleanInvariant(object? value)
    {
        return ObjectExtensions.ToBooleanInvariant(value);
    }

    public static bool BooleanOrDefaultInvariant(object? value, bool @default = default)
    {
        return ObjectExtensions.ToBooleanOrDefaultInvariant(value, @default);
    }

    public static bool BooleanLocal(object? value)
    {
        return ObjectExtensions.ToBooleanLocal(value);
    }

    public static bool BooleanOrDefaultLocal(object? value, bool @default = default)
    {
        return ObjectExtensions.ToBooleanOrDefaultLocal(value, @default);
    }

    public static byte Byte(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToByte(value, provider);
    }

    public static byte ByteOrDefault(object? value, IFormatProvider? provider, byte @default = default)
    {
        return ObjectExtensions.ToByteOrDefault(value, provider, @default);
    }

    public static byte ByteInvariant(object? value)
    {
        return ObjectExtensions.ToByteInvariant(value);
    }

    public static byte ByteOrDefaultInvariant(object? value, byte @default = default)
    {
        return ObjectExtensions.ToByteOrDefaultInvariant(value, @default);
    }

    public static byte ByteLocal(object? value)
    {
        return ObjectExtensions.ToByteLocal(value);
    }

    public static byte ByteOrDefaultLocal(object? value, byte @default = default)
    {
        return ObjectExtensions.ToByteOrDefaultLocal(value, @default);
    }

    public static char Char(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToChar(value, provider);
    }

    public static char CharOrDefault(object? value, IFormatProvider? provider, char @default = default)
    {
        return ObjectExtensions.ToCharOrDefault(value, provider, @default);
    }

    public static char CharInvariant(object? value)
    {
        return ObjectExtensions.ToCharInvariant(value);
    }

    public static char CharOrDefaultInvariant(object? value, char @default = default)
    {
        return ObjectExtensions.ToCharOrDefaultInvariant(value, @default);
    }

    public static char CharLocal(object? value)
    {
        return ObjectExtensions.ToCharLocal(value);
    }

    public static char CharOrDefaultLocal(object? value, char @default = default)
    {
        return ObjectExtensions.ToCharOrDefaultLocal(value, @default);
    }

    public static DateTime DateTime(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToDateTime(value, provider);
    }

    public static DateTime DateTimeOrDefault(object? value, IFormatProvider? provider, DateTime @default = default)
    {
        return ObjectExtensions.ToDateTimeOrDefault(value, provider, @default);
    }

    public static DateTime DateTimeInvariant(object? value)
    {
        return ObjectExtensions.ToDateTimeInvariant(value);
    }

    public static DateTime DateTimeOrDefaultInvariant(object? value, DateTime @default = default)
    {
        return ObjectExtensions.ToDateTimeOrDefaultInvariant(value, @default);
    }

    public static DateTime DateTimeLocal(object? value)
    {
        return ObjectExtensions.ToDateTimeLocal(value);
    }

    public static DateTime DateTimeOrDefaultLocal(object? value, DateTime @default = default)
    {
        return ObjectExtensions.ToDateTimeOrDefaultLocal(value, @default);
    }

    public static decimal Decimal(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToDecimal(value, provider);
    }

    public static decimal DecimalOrDefault(object? value, IFormatProvider? provider, decimal @default = default)
    {
        return ObjectExtensions.ToDecimalOrDefault(value, provider, @default);
    }

    public static decimal DecimalInvariant(object? value)
    {
        return ObjectExtensions.ToDecimalInvariant(value);
    }

    public static decimal DecimalOrDefaultInvariant(object? value, decimal @default = default)
    {
        return ObjectExtensions.ToDecimalOrDefaultInvariant(value, @default);
    }

    public static decimal DecimalLocal(object? value)
    {
        return ObjectExtensions.ToDecimalLocal(value);
    }

    public static decimal DecimalOrDefaultLocal(object? value, decimal @default = default)
    {
        return ObjectExtensions.ToDecimalOrDefaultLocal(value, @default);
    }

    public static double Double(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToDouble(value, provider);
    }

    public static double DoubleOrDefault(object? value, IFormatProvider? provider, double @default = default)
    {
        return ObjectExtensions.ToDoubleOrDefault(value, provider, @default);
    }

    public static double DoubleInvariant(object? value)
    {
        return ObjectExtensions.ToDoubleInvariant(value);
    }

    public static double DoubleOrDefaultInvariant(object? value, double @default = default)
    {
        return ObjectExtensions.ToDoubleOrDefaultInvariant(value, @default);
    }

    public static double DoubleLocal(object? value)
    {
        return ObjectExtensions.ToDoubleLocal(value);
    }

    public static double DoubleOrDefaultLocal(object? value, double @default = default)
    {
        return ObjectExtensions.ToDoubleOrDefaultLocal(value, @default);
    }

    public static short Int16(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt16(value, provider);
    }

    public static short Int16OrDefault(object? value, IFormatProvider? provider, short @default = default)
    {
        return ObjectExtensions.ToInt16OrDefault(value, provider, @default);
    }

    public static short Int16Invariant(object? value)
    {
        return ObjectExtensions.ToInt16Invariant(value);
    }

    public static short Int16OrDefaultInvariant(object? value, short @default = default)
    {
        return ObjectExtensions.ToInt16OrDefaultInvariant(value, @default);
    }

    public static short Int16Local(object? value)
    {
        return ObjectExtensions.ToInt16Local(value);
    }

    public static short Int16OrDefaultLocal(object? value, short @default = default)
    {
        return ObjectExtensions.ToInt16OrDefaultLocal(value, @default);
    }

    public static int Int32(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt32(value, provider);
    }

    public static int Int32OrDefault(object? value, IFormatProvider? provider, int @default = default)
    {
        return ObjectExtensions.ToInt32OrDefault(value, provider, @default);
    }

    public static int Int(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt32(value, provider);
    }

    public static int IntOrDefault(object? value, IFormatProvider? provider, int @default = default)
    {
        return ObjectExtensions.ToInt32OrDefault(value, provider, @default);
    }

    public static int Int32Invariant(object? value)
    {
        return ObjectExtensions.ToInt32Invariant(value);
    }

    public static int Int32OrDefaultInvariant(object? value, int @default = default)
    {
        return ObjectExtensions.ToInt32OrDefaultInvariant(value, @default);
    }

    public static int IntInvariant(object? value)
    {
        return ObjectExtensions.ToInt32Invariant(value);
    }

    public static int IntOrDefaultInvariant(object? value, int @default = default)
    {
        return ObjectExtensions.ToInt32OrDefaultInvariant(value, @default);
    }

    public static int Int32Local(object? value)
    {
        return ObjectExtensions.ToInt32Local(value);
    }

    public static int Int32OrDefaultLocal(object? value, int @default = default)
    {
        return ObjectExtensions.ToInt32OrDefaultLocal(value, @default);
    }

    public static int IntLocal(object? value)
    {
        return ObjectExtensions.ToInt32Local(value);
    }

    public static int IntOrDefaultLocal(object? value, int @default = default)
    {
        return ObjectExtensions.ToInt32OrDefaultLocal(value, @default);
    }

    public static long Int64(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt64(value, provider);
    }

    public static long Int64OrDefault(object? value, IFormatProvider? provider, long @default = default)
    {
        return ObjectExtensions.ToInt64OrDefault(value, provider, @default);
    }

    public static long Long(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToInt64(value, provider);
    }

    public static long LongOrDefault(object? value, IFormatProvider? provider, long @default = default)
    {
        return ObjectExtensions.ToInt64OrDefault(value, provider, @default);
    }

    public static long Int64Invariant(object? value)
    {
        return ObjectExtensions.ToInt64Invariant(value);
    }

    public static long Int64OrDefaultInvariant(object? value, long @default = default)
    {
        return ObjectExtensions.ToInt64OrDefaultInvariant(value, @default);
    }

    public static long LongLocalInvariant(object? value)
    {
        return ObjectExtensions.ToInt64Invariant(value);
    }

    public static long LongOrDefaultInvariant(object? value, long @default = default)
    {
        return ObjectExtensions.ToInt64OrDefaultInvariant(value, @default);
    }

    public static long Int64Local(object? value)
    {
        return ObjectExtensions.ToInt64Local(value);
    }

    public static long Int64OrDefaultLocal(object? value, long @default = default)
    {
        return ObjectExtensions.ToInt64OrDefaultLocal(value, @default);
    }

    public static long LongLocal(object? value)
    {
        return ObjectExtensions.ToInt64Local(value);
    }

    public static long LongOrDefaultLocal(object? value, long @default = default)
    {
        return ObjectExtensions.ToInt64OrDefaultLocal(value, @default);
    }

    public static sbyte SByte(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToSByte(value, provider);
    }

    public static sbyte SByteOrDefault(object? value, IFormatProvider? provider, sbyte @default = default)
    {
        return ObjectExtensions.ToSByteOrDefault(value, provider, @default);
    }

    public static sbyte SByteInvariant(object? value)
    {
        return ObjectExtensions.ToSByteInvariant(value);
    }

    public static sbyte SByteOrDefaultInvariant(object? value, sbyte @default = default)
    {
        return ObjectExtensions.ToSByteOrDefaultInvariant(value, @default);
    }

    public static sbyte SByteLocal(object? value)
    {
        return ObjectExtensions.ToSByteLocal(value);
    }

    public static sbyte SByteOrDefaultLocal(object? value, sbyte @default = default)
    {
        return ObjectExtensions.ToSByteOrDefaultLocal(value, @default);
    }

    public static float Single(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToSingle(value, provider);
    }

    public static float SingleOrDefault(object? value, IFormatProvider? provider, float @default = default)
    {
        return ObjectExtensions.ToSingleOrDefault(value, provider, @default);
    }

    public static float Float(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToSingle(value, provider);
    }

    public static float FloatOrDefault(object? value, IFormatProvider? provider, float @default = default)
    {
        return ObjectExtensions.ToSingleOrDefault(value, provider, @default);
    }

    public static float SingleInvariant(object? value)
    {
        return ObjectExtensions.ToSingleInvariant(value);
    }

    public static float SingleOrDefaultInvariant(object? value, float @default = default)
    {
        return ObjectExtensions.ToSingleOrDefaultInvariant(value, @default);
    }

    public static float FloatInvariant(object? value)
    {
        return ObjectExtensions.ToSingleInvariant(value);
    }

    public static float FloatOrDefaultInvariant(object? value, float @default = default)
    {
        return ObjectExtensions.ToSingleOrDefaultInvariant(value, @default);
    }

    public static float SingleLocal(object? value)
    {
        return ObjectExtensions.ToSingleLocal(value);
    }

    public static float SingleOrDefaultLocal(object? value, float @default = default)
    {
        return ObjectExtensions.ToSingleOrDefaultLocal(value, @default);
    }

    public static float FloatLocal(object? value)
    {
        return ObjectExtensions.ToSingleLocal(value);
    }

    public static float FloatOrDefaultLocal(object? value, float @default = default)
    {
        return ObjectExtensions.ToSingleOrDefaultLocal(value, @default);
    }

    public static ushort UInt16(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToUInt16(value, provider);
    }

    public static ushort UInt16OrDefault(object? value, IFormatProvider? provider, ushort @default = default)
    {
        return ObjectExtensions.ToUInt16OrDefault(value, provider, @default);
    }

    public static ushort UInt16Invariant(object? value)
    {
        return ObjectExtensions.ToUInt16Invariant(value);
    }

    public static ushort UInt16OrDefaultInvariant(object? value, ushort @default = default)
    {
        return ObjectExtensions.ToUInt16OrDefaultInvariant(value, @default);
    }

    public static ushort UInt16Local(object? value)
    {
        return ObjectExtensions.ToUInt16Local(value);
    }

    public static ushort UInt16OrDefaultLocal(object? value, ushort @default = default)
    {
        return ObjectExtensions.ToUInt16OrDefaultLocal(value, @default);
    }

    public static uint UInt32(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToUInt32(value, provider);
    }

    public static uint UInt32OrDefault(object? value, IFormatProvider? provider, uint @default = default)
    {
        return ObjectExtensions.ToUInt32OrDefault(value, provider, @default);
    }

    public static uint UInt(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToUInt32(value, provider);
    }

    public static uint UIntOrDefault(object? value, IFormatProvider? provider, uint @default = default)
    {
        return ObjectExtensions.ToUInt32OrDefault(value, provider, @default);
    }

    public static uint UInt32Invariant(object? value)
    {
        return ObjectExtensions.ToUInt32Invariant(value);
    }

    public static uint UInt32OrDefaultInvariant(object? value, uint @default = default)
    {
        return ObjectExtensions.ToUInt32OrDefaultInvariant(value, @default);
    }

    public static uint UIntInvariant(object? value)
    {
        return ObjectExtensions.ToUInt32Invariant(value);
    }

    public static uint UIntOrDefaultInvariant(object? value, uint @default = default)
    {
        return ObjectExtensions.ToUInt32OrDefaultInvariant(value, @default);
    }

    public static uint UInt32Local(object? value)
    {
        return ObjectExtensions.ToUInt32Local(value);
    }

    public static uint UInt32OrDefaultLocal(object? value, uint @default = default)
    {
        return ObjectExtensions.ToUInt32OrDefaultLocal(value, @default);
    }

    public static uint UIntLocal(object? value)
    {
        return ObjectExtensions.ToUInt32Local(value);
    }

    public static uint UIntOrDefaultLocal(object? value, uint @default = default)
    {
        return ObjectExtensions.ToUInt32OrDefaultLocal(value, @default);
    }

    public static ulong UInt64(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToUInt64(value, provider);
    }

    public static ulong UInt64OrDefault(object? value, IFormatProvider? provider, ulong @default = default)
    {
        return ObjectExtensions.ToUInt64OrDefault(value, provider, @default);
    }

    public static ulong ULong(object? value, IFormatProvider? provider)
    {
        return ObjectExtensions.ToUInt64(value, provider);
    }

    public static ulong ULongOrDefault(object? value, IFormatProvider? provider, ulong @default = default)
    {
        return ObjectExtensions.ToUInt64OrDefault(value, provider, @default);
    }

    public static ulong UInt64Invariant(object? value)
    {
        return ObjectExtensions.ToUInt64Invariant(value);
    }

    public static ulong UInt64OrDefaultInvariant(object? value, ulong @default = default)
    {
        return ObjectExtensions.ToUInt64OrDefaultInvariant(value, @default);
    }

    public static ulong ULongInvariant(object? value)
    {
        return ObjectExtensions.ToUInt64Invariant(value);
    }

    public static ulong ULongOrDefaultInvariant(object? value, ulong @default = default)
    {
        return ObjectExtensions.ToUInt64OrDefaultInvariant(value, @default);
    }

    public static ulong UInt64Local(object? value)
    {
        return ObjectExtensions.ToUInt64Local(value);
    }

    public static ulong UInt64OrDefaultLocal(object? value, ulong @default = default)
    {
        return ObjectExtensions.ToUInt64OrDefaultInvariant(value, @default);
    }

    public static ulong ULongLocal(object? value)
    {
        return ObjectExtensions.ToUInt64Local(value);
    }

    public static ulong ULongOrDefaultLocal(object? value, ulong @default = default)
    {
        return ObjectExtensions.ToUInt64OrDefaultInvariant(value, @default);
    }
}
