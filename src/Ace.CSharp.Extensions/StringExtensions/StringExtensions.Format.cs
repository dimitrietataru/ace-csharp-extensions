namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string FormatInvariant(this string format, object? arg0)
    {
        return string.Format(CultureInfo.InvariantCulture, format, arg0);
    }

    public static string FormatInvariant(this string format, object? arg0, object? arg1)
    {
        return string.Format(CultureInfo.InvariantCulture, format, arg0, arg1);
    }

    public static string FormatInvariant(this string format, object? arg0, object? arg1, object? arg2)
    {
        return string.Format(CultureInfo.InvariantCulture, format, arg0, arg1, arg2);
    }

    public static string FormatInvariant(this string format, object?[] args)
    {
        return string.Format(CultureInfo.InvariantCulture, format, args);
    }

    public static string FormatLocal(this string format, object? arg0)
    {
        return string.Format(CultureInfo.CurrentCulture, format, arg0);
    }

    public static string FormatLocal(this string format, object? arg0, object? arg1)
    {
        return string.Format(CultureInfo.CurrentCulture, format, arg0, arg1);
    }

    public static string FormatLocal(this string format, object? arg0, object? arg1, object? arg2)
    {
        return string.Format(CultureInfo.CurrentCulture, format, arg0, arg1, arg2);
    }

    public static string FormatLocal(this string format, object?[] args)
    {
        return string.Format(CultureInfo.CurrentCulture, format, args);
    }
}
