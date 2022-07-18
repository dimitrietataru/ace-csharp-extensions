namespace Ace.CSharp.Extensions.ConvertExtensions;

public static class ConvertInvariant
{
    private static readonly CultureInfo invariantCulture = CultureInfo.InvariantCulture;

    public static bool ToBoolean(object? value) => Convert.ToBoolean(value, invariantCulture);
    public static bool ToBoolean(string? value) => Convert.ToBoolean(value, invariantCulture);

    public static byte ToByte(object? value) => Convert.ToByte(value, invariantCulture);
    public static byte ToByte(string? value) => Convert.ToByte(value, invariantCulture);

    public static char ToChar(object? value) => Convert.ToChar(value, invariantCulture);
    public static char ToChar(string value) => Convert.ToChar(value, invariantCulture);

    public static DateTime ToDateTime(object? value) => Convert.ToDateTime(value, invariantCulture);
    public static DateTime ToDateTime(string? value) => Convert.ToDateTime(value, invariantCulture);

    public static decimal ToDecimal(object? value) => Convert.ToDecimal(value, invariantCulture);
    public static decimal ToDecimal(string? value) => Convert.ToDecimal(value, invariantCulture);

    public static double ToDouble(object? value) => Convert.ToDouble(value, invariantCulture);
    public static double ToDouble(string? value) => Convert.ToDouble(value, invariantCulture);

    public static short ToInt16(object? value) => Convert.ToInt16(value, invariantCulture);
    public static short ToInt16(string? value) => Convert.ToInt16(value, invariantCulture);

    public static int ToInt32(object? value) => Convert.ToInt32(value, invariantCulture);
    public static int ToInt32(string? value) => Convert.ToInt32(value, invariantCulture);
    public static int ToInt(object? value) => ToInt32(value);
    public static int ToInt(string? value) => ToInt32(value);

    public static long ToInt64(object? value) => Convert.ToInt64(value, invariantCulture);
    public static long ToInt64(string? value) => Convert.ToInt64(value, invariantCulture);
    public static long ToLong(object? value) => ToInt64(value);
    public static long ToLong(string? value) => ToInt64(value);

    public static sbyte ToSByte(object? value) => Convert.ToSByte(value, invariantCulture);
    public static sbyte ToSByte(string value) => Convert.ToSByte(value, invariantCulture);

    public static float ToSingle(object? value) => Convert.ToSingle(value, invariantCulture);
    public static float ToSingle(string? value) => Convert.ToSingle(value, invariantCulture);
    public static float ToFloat(object? value) => ToSingle(value);
    public static float ToFloat(string? value) => ToSingle(value);

    public static ushort ToUInt16(object? value) => Convert.ToUInt16(value, invariantCulture);
    public static ushort ToUInt16(string? value) => Convert.ToUInt16(value, invariantCulture);

    public static uint ToUInt32(object? value) => Convert.ToUInt32(value, invariantCulture);
    public static uint ToUInt32(string? value) => Convert.ToUInt32(value, invariantCulture);
    public static uint ToUInt(object? value) => ToUInt32(value);
    public static uint ToUInt(string? value) => ToUInt32(value);

    public static ulong ToUInt64(object? value) => Convert.ToUInt64(value, invariantCulture);
    public static ulong ToUInt64(string? value) => Convert.ToUInt64(value, invariantCulture);
    public static ulong ToULong(object? value) => ToUInt64(value);
    public static ulong ToULong(string? value) => ToUInt64(value);
}
