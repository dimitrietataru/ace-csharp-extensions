namespace Ace.CSharp.Extensions;

public static class ConvertLocal
{
    private static readonly CultureInfo localCulture = CultureInfo.CurrentCulture;

    public static bool ToBoolean(object? value) => Convert.ToBoolean(value, localCulture);
    public static bool ToBoolean(string? value) => Convert.ToBoolean(value, localCulture);

    public static byte ToByte(object? value) => Convert.ToByte(value, localCulture);
    public static byte ToByte(string? value) => Convert.ToByte(value, localCulture);

    public static char ToChar(object? value) => Convert.ToChar(value, localCulture);
    public static char ToChar(string value) => Convert.ToChar(value, localCulture);

    public static DateTime ToDateTime(object? value) => Convert.ToDateTime(value, localCulture);
    public static DateTime ToDateTime(string? value) => Convert.ToDateTime(value, localCulture);

    public static decimal ToDecimal(object? value) => Convert.ToDecimal(value, localCulture);
    public static decimal ToDecimal(string? value) => Convert.ToDecimal(value, localCulture);

    public static double ToDouble(object? value) => Convert.ToDouble(value, localCulture);
    public static double ToDouble(string? value) => Convert.ToDouble(value, localCulture);

    public static short ToInt16(object? value) => Convert.ToInt16(value, localCulture);
    public static short ToInt16(string? value) => Convert.ToInt16(value, localCulture);

    public static int ToInt32(object? value) => Convert.ToInt32(value, localCulture);
    public static int ToInt32(string? value) => Convert.ToInt32(value, localCulture);
    public static int ToInt(object? value) => ToInt32(value);
    public static int ToInt(string? value) => ToInt32(value);

    public static long ToInt64(object? value) => Convert.ToInt64(value, localCulture);
    public static long ToInt64(string? value) => Convert.ToInt64(value, localCulture);
    public static long ToLong(object? value) => ToInt64(value);
    public static long ToLong(string? value) => ToInt64(value);

    public static sbyte ToSByte(object? value) => Convert.ToSByte(value, localCulture);
    public static sbyte ToSByte(string value) => Convert.ToSByte(value, localCulture);

    public static float ToSingle(object? value) => Convert.ToSingle(value, localCulture);
    public static float ToSingle(string? value) => Convert.ToSingle(value, localCulture);
    public static float ToFloat(object? value) => ToSingle(value);
    public static float ToFloat(string? value) => ToSingle(value);

    public static ushort ToUInt16(object? value) => Convert.ToUInt16(value, localCulture);
    public static ushort ToUInt16(string? value) => Convert.ToUInt16(value, localCulture);

    public static uint ToUInt32(object? value) => Convert.ToUInt32(value, localCulture);
    public static uint ToUInt32(string? value) => Convert.ToUInt32(value, localCulture);
    public static uint ToUInt(object? value) => ToUInt32(value);
    public static uint ToUInt(string? value) => ToUInt32(value);

    public static ulong ToUInt64(object? value) => Convert.ToUInt64(value, localCulture);
    public static ulong ToUInt64(string? value) => Convert.ToUInt64(value, localCulture);
    public static ulong ToULong(object? value) => ToUInt64(value);
    public static ulong ToULong(string? value) => ToUInt64(value);
}
