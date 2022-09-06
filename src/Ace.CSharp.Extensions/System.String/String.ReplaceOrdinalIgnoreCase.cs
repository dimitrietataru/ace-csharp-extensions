namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static string ReplaceOrdinalIgnoreCase(this string @this, string oldValue, string? newValue)
    {
        return @this.Replace(oldValue, newValue, StringComparison.OrdinalIgnoreCase);
    }
}
