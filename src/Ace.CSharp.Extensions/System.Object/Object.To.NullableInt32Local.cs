namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static int? ToNullableInt32Local(this object? value)
    {
        return value.ToNullableInt32(CultureInfo.CurrentCulture);
    }

    public static int? ToNullableIntLocal(this object? value)
    {
        return value.ToNullableInt32Local();
    }
}
