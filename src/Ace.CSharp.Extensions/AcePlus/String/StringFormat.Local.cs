namespace Ace.CSharp.Extensions;

public static partial class StringFormat
{
    public static string Local(string format, object? arg0)
    {
        return format.FormatLocal(arg0);
    }

    public static string Local(string format, object? arg0, object? arg1)
    {
        return format.FormatLocal(arg0, arg1);
    }

    public static string Local(string format, object? arg0, object? arg1, object? arg2)
    {
        return format.FormatLocal(arg0, arg1, arg2);
    }

    public static string Local(string format, object?[] args)
    {
        return format.FormatLocal(args);
    }
}
