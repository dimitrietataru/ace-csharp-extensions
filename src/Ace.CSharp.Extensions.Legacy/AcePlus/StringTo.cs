using System;

namespace Ace.CSharp.Extensions
{
    public static class StringTo
    {
        public static bool Boolean(string value, IFormatProvider provider)
        {
            return StringExtensions.ToBoolean(value, provider);
        }

        public static bool BooleanOrDefault(string value, IFormatProvider provider, bool @default = default)
        {
            return StringExtensions.ToBooleanOrDefault(value, provider, @default);
        }

        public static bool? BooleanOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToBooleanOrNull(value, provider);
        }

        public static bool BooleanInvariant(string value)
        {
            return StringExtensions.ToBooleanInvariant(value);
        }

        public static bool BooleanOrDefaultInvariant(string value, bool @default = default)
        {
            return StringExtensions.ToBooleanOrDefaultInvariant(value, @default);
        }

        public static bool? BooleanOrNullInvariant(string value)
        {
            return StringExtensions.ToBooleanOrNullInvariant(value);
        }

        public static bool BooleanLocal(string value)
        {
            return StringExtensions.ToBooleanLocal(value);
        }

        public static bool BooleanOrDefaultLocal(string value, bool @default = default)
        {
            return StringExtensions.ToBooleanOrDefaultLocal(value, @default);
        }

        public static bool? BooleanOrNullLocal(string value)
        {
            return StringExtensions.ToBooleanOrNullLocal(value);
        }

        public static byte Byte(string value, IFormatProvider provider)
        {
            return StringExtensions.ToByte(value, provider);
        }

        public static byte ByteOrDefault(string value, IFormatProvider provider, byte @default = default)
        {
            return StringExtensions.ToByteOrDefault(value, provider, @default);
        }

        public static byte? ByteOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToByteOrNull(value, provider);
        }

        public static byte ByteInvariant(string value)
        {
            return StringExtensions.ToByteInvariant(value);
        }

        public static byte ByteOrDefaultInvariant(string value, byte @default = default)
        {
            return StringExtensions.ToByteOrDefaultInvariant(value, @default);
        }

        public static byte? ByteOrNullInvariant(string value)
        {
            return StringExtensions.ToByteOrNullInvariant(value);
        }

        public static byte ByteLocal(string value)
        {
            return StringExtensions.ToByteLocal(value);
        }

        public static byte ByteOrDefaultLocal(string value, byte @default = default)
        {
            return StringExtensions.ToByteOrDefaultLocal(value, @default);
        }

        public static byte? ByteOrNullLocal(string value)
        {
            return StringExtensions.ToByteOrNullLocal(value);
        }

        public static char Char(string value, IFormatProvider provider)
        {
            return StringExtensions.ToChar(value, provider);
        }

        public static char CharOrDefault(string value, IFormatProvider provider, char @default = default)
        {
            return StringExtensions.ToCharOrDefault(value, provider, @default);
        }

        public static char? CharOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToCharOrNull(value, provider);
        }

        public static char CharInvariant(string value)
        {
            return StringExtensions.ToCharInvariant(value);
        }

        public static char CharOrDefaultInvariant(string value, char @default = default)
        {
            return StringExtensions.ToCharOrDefaultInvariant(value, @default);
        }

        public static char? CharOrNullInvariant(string value)
        {
            return StringExtensions.ToCharOrNullInvariant(value);
        }

        public static char CharLocal(string value)
        {
            return StringExtensions.ToCharLocal(value);
        }

        public static char CharOrDefaultLocal(string value, char @default = default)
        {
            return StringExtensions.ToCharOrDefaultLocal(value, @default);
        }

        public static char? CharOrNullLocal(string value)
        {
            return StringExtensions.ToCharOrNullLocal(value);
        }

        public static DateTime DateTime(string value, IFormatProvider provider)
        {
            return StringExtensions.ToDateTime(value, provider);
        }

        public static DateTime DateTimeOrDefault(string value, IFormatProvider provider, DateTime @default = default)
        {
            return StringExtensions.ToDateTimeOrDefault(value, provider, @default);
        }

        public static DateTime? DateTimeOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToDateTimeOrNull(value, provider);
        }

        public static DateTime DateTimeInvariant(string value)
        {
            return StringExtensions.ToDateTimeInvariant(value);
        }

        public static DateTime DateTimeOrDefaultInvariant(string value, DateTime @default = default)
        {
            return StringExtensions.ToDateTimeOrDefaultInvariant(value, @default);
        }

        public static DateTime? DateTimeOrNullInvariant(string value)
        {
            return StringExtensions.ToDateTimeOrNullInvariant(value);
        }

        public static DateTime DateTimeLocal(string value)
        {
            return StringExtensions.ToDateTimeLocal(value);
        }

        public static DateTime DateTimeOrDefaultLocal(string value, DateTime @default = default)
        {
            return StringExtensions.ToDateTimeOrDefaultLocal(value, @default);
        }

        public static DateTime? DateTimeOrNullLocal(string value)
        {
            return StringExtensions.ToDateTimeOrNullLocal(value);
        }

        public static decimal Decimal(string value, IFormatProvider provider)
        {
            return StringExtensions.ToDecimal(value, provider);
        }

        public static decimal DecimalOrDefault(string value, IFormatProvider provider, decimal @default = default)
        {
            return StringExtensions.ToDecimalOrDefault(value, provider, @default);
        }

        public static decimal? DecimalOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToDecimalOrNull(value, provider);
        }

        public static decimal DecimalInvariant(string value)
        {
            return StringExtensions.ToDecimalInvariant(value);
        }

        public static decimal DecimalOrDefaultInvariant(string value, decimal @default = default)
        {
            return StringExtensions.ToDecimalOrDefaultInvariant(value, @default);
        }

        public static decimal? DecimalOrNullInvariant(string value)
        {
            return StringExtensions.ToDecimalOrNullInvariant(value);
        }

        public static decimal DecimalLocal(string value)
        {
            return StringExtensions.ToDecimalLocal(value);
        }

        public static decimal DecimalOrDefaultLocal(string value, decimal @default = default)
        {
            return StringExtensions.ToDecimalOrDefaultLocal(value, @default);
        }

        public static decimal? DecimalOrNullLocal(string value)
        {
            return StringExtensions.ToDecimalOrNullLocal(value);
        }

        public static double Double(string value, IFormatProvider provider)
        {
            return StringExtensions.ToDouble(value, provider);
        }

        public static double DoubleOrDefault(string value, IFormatProvider provider, double @default = default)
        {
            return StringExtensions.ToDoubleOrDefault(value, provider, @default);
        }

        public static double? DoubleOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToDoubleOrNull(value, provider);
        }

        public static double DoubleInvariant(string value)
        {
            return StringExtensions.ToDoubleInvariant(value);
        }

        public static double DoubleOrDefaultInvariant(string value, double @default = default)
        {
            return StringExtensions.ToDoubleOrDefaultInvariant(value, @default);
        }

        public static double? DoubleOrNullInvariant(string value)
        {
            return StringExtensions.ToDoubleOrNullInvariant(value);
        }

        public static double DoubleLocal(string value)
        {
            return StringExtensions.ToDoubleLocal(value);
        }

        public static double DoubleOrDefaultLocal(string value, double @default = default)
        {
            return StringExtensions.ToDoubleOrDefaultLocal(value, @default);
        }

        public static double? DoubleOrNullLocal(string value)
        {
            return StringExtensions.ToDoubleOrNullLocal(value);
        }

        public static short Int16(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt16(value, provider);
        }

        public static short Int16OrDefault(string value, IFormatProvider provider, short @default = default)
        {
            return StringExtensions.ToInt16OrDefault(value, provider, @default);
        }

        public static short? Int16OrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt16OrNull(value, provider);
        }

        public static short Int16Invariant(string value)
        {
            return StringExtensions.ToInt16Invariant(value);
        }

        public static short Int16OrDefaultInvariant(string value, short @default = default)
        {
            return StringExtensions.ToInt16OrDefaultInvariant(value, @default);
        }

        public static short? Int16OrNullInvariant(string value)
        {
            return StringExtensions.ToInt16OrNullInvariant(value);
        }

        public static short Int16Local(string value)
        {
            return StringExtensions.ToInt16Local(value);
        }

        public static short Int16OrDefaultLocal(string value, short @default = default)
        {
            return StringExtensions.ToInt16OrDefaultLocal(value, @default);
        }

        public static short? Int16OrNullLocal(string value)
        {
            return StringExtensions.ToInt16OrNullLocal(value);
        }

        public static int Int32(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt32(value, provider);
        }

        public static int Int32OrDefault(string value, IFormatProvider provider, int @default = default)
        {
            return StringExtensions.ToInt32OrDefault(value, provider, @default);
        }

        public static int? Int32OrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt32OrNull(value, provider);
        }

        public static int Int(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt32(value, provider);
        }

        public static int IntOrDefault(string value, IFormatProvider provider, int @default = default)
        {
            return StringExtensions.ToInt32OrDefault(value, provider, @default);
        }

        public static int? IntOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt32OrNull(value, provider);
        }

        public static int Int32Invariant(string value)
        {
            return StringExtensions.ToInt32Invariant(value);
        }

        public static int Int32OrDefaultInvariant(string value, int @default = default)
        {
            return StringExtensions.ToInt32OrDefaultInvariant(value, @default);
        }

        public static int? Int32OrNullInvariant(string value)
        {
            return StringExtensions.ToInt32OrNullInvariant(value);
        }

        public static int IntInvariant(string value)
        {
            return StringExtensions.ToInt32Invariant(value);
        }

        public static int IntOrDefaultInvariant(string value, int @default = default)
        {
            return StringExtensions.ToInt32OrDefaultInvariant(value, @default);
        }

        public static int? IntOrNullInvariant(string value)
        {
            return StringExtensions.ToInt32OrNullInvariant(value);
        }

        public static int Int32Local(string value)
        {
            return StringExtensions.ToInt32Local(value);
        }

        public static int Int32OrDefaultLocal(string value, int @default = default)
        {
            return StringExtensions.ToInt32OrDefaultLocal(value, @default);
        }

        public static int? Int32OrNullLocal(string value)
        {
            return StringExtensions.ToInt32OrNullLocal(value);
        }

        public static int IntLocal(string value)
        {
            return StringExtensions.ToInt32Local(value);
        }

        public static int IntOrDefaultLocal(string value, int @default = default)
        {
            return StringExtensions.ToInt32OrDefaultLocal(value, @default);
        }

        public static int? IntOrNullLocal(string value)
        {
            return StringExtensions.ToInt32OrNullLocal(value);
        }

        public static long Int64(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt64(value, provider);
        }

        public static long Int64OrDefault(string value, IFormatProvider provider, long @default = default)
        {
            return StringExtensions.ToInt64OrDefault(value, provider, @default);
        }

        public static long? Int64OrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt64OrNull(value, provider);
        }

        public static long Long(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt64(value, provider);
        }

        public static long LongOrDefault(string value, IFormatProvider provider, long @default = default)
        {
            return StringExtensions.ToInt64OrDefault(value, provider, @default);
        }

        public static long? LongOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToInt64OrNull(value, provider);
        }

        public static long Int64Invariant(string value)
        {
            return StringExtensions.ToInt64Invariant(value);
        }

        public static long Int64OrDefaultInvariant(string value, long @default = default)
        {
            return StringExtensions.ToInt64OrDefaultInvariant(value, @default);
        }

        public static long? Int64OrNullInvariant(string value)
        {
            return StringExtensions.ToInt64OrNullInvariant(value);
        }

        public static long LongLocalInvariant(string value)
        {
            return StringExtensions.ToInt64Invariant(value);
        }

        public static long LongOrDefaultInvariant(string value, long @default = default)
        {
            return StringExtensions.ToInt64OrDefaultInvariant(value, @default);
        }

        public static long? LongOrNullInvariant(string value)
        {
            return StringExtensions.ToInt64OrNullInvariant(value);
        }

        public static long Int64Local(string value)
        {
            return StringExtensions.ToInt64Local(value);
        }

        public static long Int64OrDefaultLocal(string value, long @default = default)
        {
            return StringExtensions.ToInt64OrDefaultLocal(value, @default);
        }

        public static long? Int64OrNullLocal(string value)
        {
            return StringExtensions.ToInt64OrNullLocal(value);
        }

        public static long LongLocal(string value)
        {
            return StringExtensions.ToInt64Local(value);
        }

        public static long LongOrDefaultLocal(string value, long @default = default)
        {
            return StringExtensions.ToInt64OrDefaultLocal(value, @default);
        }

        public static long? LongOrNullLocal(string value)
        {
            return StringExtensions.ToInt64OrNullLocal(value);
        }

        public static sbyte SByte(string value, IFormatProvider provider)
        {
            return StringExtensions.ToSByte(value, provider);
        }

        public static sbyte SByteOrDefault(string value, IFormatProvider provider, sbyte @default = default)
        {
            return StringExtensions.ToSByteOrDefault(value, provider, @default);
        }

        public static sbyte? SByteOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToSByteOrNull(value, provider);
        }

        public static sbyte SByteInvariant(string value)
        {
            return StringExtensions.ToSByteInvariant(value);
        }

        public static sbyte SByteOrDefaultInvariant(string value, sbyte @default = default)
        {
            return StringExtensions.ToSByteOrDefaultInvariant(value, @default);
        }

        public static sbyte? SByteOrNullInvariant(string value)
        {
            return StringExtensions.ToSByteOrNullInvariant(value);
        }

        public static sbyte SByteLocal(string value)
        {
            return StringExtensions.ToSByteLocal(value);
        }

        public static sbyte SByteOrDefaultLocal(string value, sbyte @default = default)
        {
            return StringExtensions.ToSByteOrDefaultLocal(value, @default);
        }

        public static sbyte? SByteOrNullLocal(string value)
        {
            return StringExtensions.ToSByteOrNullLocal(value);
        }

        public static float Single(string value, IFormatProvider provider)
        {
            return StringExtensions.ToSingle(value, provider);
        }

        public static float SingleOrDefault(string value, IFormatProvider provider, float @default = default)
        {
            return StringExtensions.ToSingleOrDefault(value, provider, @default);
        }

        public static float? SingleOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToSingleOrNull(value, provider);
        }

        public static float Float(string value, IFormatProvider provider)
        {
            return StringExtensions.ToSingle(value, provider);
        }

        public static float FloatOrDefault(string value, IFormatProvider provider, float @default = default)
        {
            return StringExtensions.ToSingleOrDefault(value, provider, @default);
        }

        public static float? FloatOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToSingleOrNull(value, provider);
        }

        public static float SingleInvariant(string value)
        {
            return StringExtensions.ToSingleInvariant(value);
        }

        public static float SingleOrDefaultInvariant(string value, float @default = default)
        {
            return StringExtensions.ToSingleOrDefaultInvariant(value, @default);
        }

        public static float? SingleOrNullInvariant(string value)
        {
            return StringExtensions.ToSingleOrNullInvariant(value);
        }

        public static float FloatInvariant(string value)
        {
            return StringExtensions.ToSingleInvariant(value);
        }

        public static float FloatOrDefaultInvariant(string value, float @default = default)
        {
            return StringExtensions.ToSingleOrDefaultInvariant(value, @default);
        }

        public static float? FloatOrNullInvariant(string value)
        {
            return StringExtensions.ToSingleOrNullInvariant(value);
        }

        public static float SingleLocal(string value)
        {
            return StringExtensions.ToSingleLocal(value);
        }

        public static float SingleOrDefaultLocal(string value, float @default = default)
        {
            return StringExtensions.ToSingleOrDefaultLocal(value, @default);
        }

        public static float? SingleOrNullLocal(string value)
        {
            return StringExtensions.ToSingleOrNullLocal(value);
        }

        public static float FloatLocal(string value)
        {
            return StringExtensions.ToSingleLocal(value);
        }

        public static float FloatOrDefaultLocal(string value, float @default = default)
        {
            return StringExtensions.ToSingleOrDefaultLocal(value, @default);
        }

        public static float? FloatOrNullLocal(string value)
        {
            return StringExtensions.ToSingleOrNullLocal(value);
        }

        public static ushort UInt16(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt16(value, provider);
        }

        public static ushort UInt16OrDefault(string value, IFormatProvider provider, ushort @default = default)
        {
            return StringExtensions.ToUInt16OrDefault(value, provider, @default);
        }

        public static ushort? UInt16OrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt16OrNull(value, provider);
        }

        public static ushort UInt16Invariant(string value)
        {
            return StringExtensions.ToUInt16Invariant(value);
        }

        public static ushort UInt16OrDefaultInvariant(string value, ushort @default = default)
        {
            return StringExtensions.ToUInt16OrDefaultInvariant(value, @default);
        }

        public static ushort? UInt16OrNullInvariant(string value)
        {
            return StringExtensions.ToUInt16OrNullInvariant(value);
        }

        public static ushort UInt16Local(string value)
        {
            return StringExtensions.ToUInt16Local(value);
        }

        public static ushort UInt16OrDefaultLocal(string value, ushort @default = default)
        {
            return StringExtensions.ToUInt16OrDefaultLocal(value, @default);
        }

        public static ushort? UInt16OrNullLocal(string value)
        {
            return StringExtensions.ToUInt16OrNullLocal(value);
        }

        public static uint UInt32(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt32(value, provider);
        }

        public static uint UInt32OrDefault(string value, IFormatProvider provider, uint @default = default)
        {
            return StringExtensions.ToUInt32OrDefault(value, provider, @default);
        }

        public static uint? UInt32OrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt32OrNull(value, provider);
        }

        public static uint UInt(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt32(value, provider);
        }

        public static uint UIntOrDefault(string value, IFormatProvider provider, uint @default = default)
        {
            return StringExtensions.ToUInt32OrDefault(value, provider, @default);
        }

        public static uint? UIntOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt32OrNull(value, provider);
        }

        public static uint UInt32Invariant(string value)
        {
            return StringExtensions.ToUInt32Invariant(value);
        }

        public static uint UInt32OrDefaultInvariant(string value, uint @default = default)
        {
            return StringExtensions.ToUInt32OrDefaultInvariant(value, @default);
        }

        public static uint? UInt32OrNullInvariant(string value)
        {
            return StringExtensions.ToUInt32OrNullInvariant(value);
        }

        public static uint UIntInvariant(string value)
        {
            return StringExtensions.ToUInt32Invariant(value);
        }

        public static uint UIntOrDefaultInvariant(string value, uint @default = default)
        {
            return StringExtensions.ToUInt32OrDefaultInvariant(value, @default);
        }

        public static uint? UIntOrNullInvariant(string value)
        {
            return StringExtensions.ToUInt32OrNullInvariant(value);
        }

        public static uint UInt32Local(string value)
        {
            return StringExtensions.ToUInt32Local(value);
        }

        public static uint UInt32OrDefaultLocal(string value, uint @default = default)
        {
            return StringExtensions.ToUInt32OrDefaultLocal(value, @default);
        }

        public static uint? UInt32OrNullLocal(string value)
        {
            return StringExtensions.ToUInt32OrNullLocal(value);
        }

        public static uint UIntLocal(string value)
        {
            return StringExtensions.ToUInt32Local(value);
        }

        public static uint UIntOrDefaultLocal(string value, uint @default = default)
        {
            return StringExtensions.ToUInt32OrDefaultLocal(value, @default);
        }

        public static uint? UIntOrNullLocal(string value)
        {
            return StringExtensions.ToUInt32OrNullLocal(value);
        }

        public static ulong UInt64(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt64(value, provider);
        }

        public static ulong UInt64OrDefault(string value, IFormatProvider provider, ulong @default = default)
        {
            return StringExtensions.ToUInt64OrDefault(value, provider, @default);
        }

        public static ulong? UInt64OrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt64OrNull(value, provider);
        }

        public static ulong ULong(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt64(value, provider);
        }

        public static ulong ULongOrDefault(string value, IFormatProvider provider, ulong @default = default)
        {
            return StringExtensions.ToUInt64OrDefault(value, provider, @default);
        }

        public static ulong? ULongOrNull(string value, IFormatProvider provider)
        {
            return StringExtensions.ToUInt64OrNull(value, provider);
        }

        public static ulong UInt64Invariant(string value)
        {
            return StringExtensions.ToUInt64Invariant(value);
        }

        public static ulong UInt64OrDefaultInvariant(string value, ulong @default = default)
        {
            return StringExtensions.ToUInt64OrDefaultInvariant(value, @default);
        }

        public static ulong? UInt64OrNullInvariant(string value)
        {
            return StringExtensions.ToUInt64OrNullInvariant(value);
        }

        public static ulong ULongInvariant(string value)
        {
            return StringExtensions.ToUInt64Invariant(value);
        }

        public static ulong ULongOrDefaultInvariant(string value, ulong @default = default)
        {
            return StringExtensions.ToUInt64OrDefaultInvariant(value, @default);
        }

        public static ulong? ULongOrNullInvariant(string value)
        {
            return StringExtensions.ToUInt64OrNullInvariant(value);
        }

        public static ulong UInt64Local(string value)
        {
            return StringExtensions.ToUInt64Local(value);
        }

        public static ulong UInt64OrDefaultLocal(string value, ulong @default = default)
        {
            return StringExtensions.ToUInt64OrDefaultInvariant(value, @default);
        }

        public static ulong? UInt64OrNullLocal(string value)
        {
            return StringExtensions.ToUInt64OrNullInvariant(value);
        }

        public static ulong ULongLocal(string value)
        {
            return StringExtensions.ToUInt64Local(value);
        }

        public static ulong ULongOrDefaultLocal(string value, ulong @default = default)
        {
            return StringExtensions.ToUInt64OrDefaultInvariant(value, @default);
        }

        public static ulong? ULongOrNullLocal(string value)
        {
            return StringExtensions.ToUInt64OrNullInvariant(value);
        }
    }
}
