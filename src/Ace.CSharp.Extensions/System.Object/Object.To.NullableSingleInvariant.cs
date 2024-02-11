namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static float? ToNullableSingleInvariant(this object? value)
    {
        return value.ToNullableSingle(CultureInfo.InvariantCulture);
    }
}
