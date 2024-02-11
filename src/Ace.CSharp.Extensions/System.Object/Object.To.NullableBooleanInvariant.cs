namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static bool? ToNullableBooleanInvariant(this object? value)
    {
        return value.ToNullableBoolean(CultureInfo.InvariantCulture);
    }
}
