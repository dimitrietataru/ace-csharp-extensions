namespace Ace.CSharp.Extensions;

public static partial class StringFormat
{
    public static string Invariant(string format, object? arg0)
    {
        return format.FormatInvariant(arg0);
    }

    public static string Invariant(string format, object? arg0, object? arg1)
    {
        return format.FormatInvariant(arg0, arg1);
    }

    public static string Invariant(string format, object? arg0, object? arg1, object? arg2)
    {
        return format.FormatInvariant(arg0, arg1, arg2);
    }

    public static string Invariant(string format, object?[] args)
    {
        return format.FormatInvariant(args);
    }
}
