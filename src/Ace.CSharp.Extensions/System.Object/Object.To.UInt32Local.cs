namespace Ace.CSharp.Extensions;

public static partial class ObjectExtensions
{
    public static uint ToUInt32Local(this object? @this)
    {
        return ToUInt32(@this, CultureInfo.CurrentCulture);
    }

    public static uint ToUInt32OrDefaultLocal(this object? @this, uint @default = default)
    {
        return ToUInt32OrDefault(@this, CultureInfo.CurrentCulture, @default);
    }

    public static uint? ToUInt32OrNullLocal(this object? @this)
    {
        return ToUInt32OrNull(@this, CultureInfo.CurrentCulture);
    }

    public static bool TryConvertToUInt32Local(this object? @this, out uint result)
    {
        return TryConvertToUInt32(@this, CultureInfo.CurrentCulture, out result);
    }

    public static uint ToUIntLocal(this object? @this)
    {
        return ToUInt32Local(@this);
    }

    public static uint ToUIntOrDefaultLocal(this object? @this, uint @default = default)
    {
        return ToUInt32OrDefaultLocal(@this, @default);
    }

    public static uint? ToUIntOrNullLocal(this object? @this)
    {
        return ToUInt32OrNullLocal(@this);
    }

    public static bool TryConvertToUIntLocal(this object? @this, out uint result)
    {
        return TryConvertToUInt32Local(@this, out result);
    }
}
