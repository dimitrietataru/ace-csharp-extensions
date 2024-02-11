namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static decimal? ToNullableDecimalLocal(this object? value)
    {
        return value.ToNullableDecimal(CultureInfo.CurrentCulture);
    }
}
