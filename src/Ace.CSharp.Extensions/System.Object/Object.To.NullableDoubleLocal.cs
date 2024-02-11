namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static double? ToNullableDoubleLocal(this object? value)
    {
        return value.ToNullableDouble(CultureInfo.CurrentCulture);
    }
}
