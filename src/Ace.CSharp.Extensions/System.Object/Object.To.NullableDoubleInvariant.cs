namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static double? ToNullableDoubleInvariant(this object? value)
    {
        return value.ToNullableDouble(CultureInfo.InvariantCulture);
    }
}
