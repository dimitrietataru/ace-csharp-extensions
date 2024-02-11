namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static bool? ToNullableBooleanLocal(this object? value)
    {
        return value.ToNullableBoolean(CultureInfo.CurrentCulture);
    }
}
