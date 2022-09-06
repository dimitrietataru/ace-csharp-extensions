namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string FormatLocal(this string @this, object? arg0)
    {
        return string.Format(CultureInfo.CurrentCulture, @this, arg0);
    }

    public static string FormatLocal(this string @this, object? arg0, object? arg1)
    {
        return string.Format(CultureInfo.CurrentCulture, @this, arg0, arg1);
    }

    public static string FormatLocal(this string @this, object? arg0, object? arg1, object? arg2)
    {
        return string.Format(CultureInfo.CurrentCulture, @this, arg0, arg1, arg2);
    }

    public static string FormatLocal(this string @this, object?[] args)
    {
        return string.Format(CultureInfo.CurrentCulture, @this, args);
    }
}
