namespace Ace.CSharp.Extensions;

public static class StringFormat
{
    public static string Invariant(string format, object? arg0)
    {
        return StringExtensions.FormatInvariant(format, arg0);
    }

    public static string Invariant(string format, object? arg0, object? arg1)
    {
        return StringExtensions.FormatInvariant(format, arg0, arg1);
    }

    public static string Invariant(string format, object? arg0, object? arg1, object? arg2)
    {
        return StringExtensions.FormatInvariant(format, arg0, arg1, arg2);
    }

    public static string Invariant(string format, object?[] args)
    {
        return StringExtensions.FormatInvariant(format, args);
    }

    public static string Local(string format, object? arg0)
    {
        return StringExtensions.FormatLocal(format, arg0);
    }

    public static string Local(string format, object? arg0, object? arg1)
    {
        return StringExtensions.FormatLocal(format, arg0, arg1);
    }

    public static string Local(string format, object? arg0, object? arg1, object? arg2)
    {
        return StringExtensions.FormatLocal(format, arg0, arg1, arg2);
    }

    public static string Local(string format, object?[] args)
    {
        return StringExtensions.FormatLocal(format, args);
    }
}
