namespace Ace.CSharp.Extensions;

public static partial class StringExtensions
{
    public static DateTime ToDateTime(this string? @this, IFormatProvider? provider)
    {
        return Convert.ToDateTime(@this, provider);
    }

    public static DateTime ToDateTimeOrDefault(this string? @this, IFormatProvider? provider, DateTime @default = default)
    {
        bool isDateTime = TryConvertToDateTime(@this, provider, out var result);

        return isDateTime ? result : @default;
    }

    public static DateTime? ToDateTimeOrNull(this string? @this, IFormatProvider? provider)
    {
        if (string.IsNullOrWhiteSpace(@this))
        {
            return null;
        }

        bool isDateTime = TryConvertToDateTime(@this, provider, out var result);

        return isDateTime ? result : null;
    }

    public static bool TryConvertToDateTime(this string? @this, IFormatProvider? provider, out DateTime result)
    {
        try
        {
            result = Convert.ToDateTime(@this, provider);

            return true;
        }
        catch (FormatException)
        {
            result = default;

            return false;
        }
    }
}
