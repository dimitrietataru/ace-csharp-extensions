using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static float ToSingleLocal(this object @this)
        {
            return ToSingle(@this, CultureInfo.CurrentCulture);
        }

        public static float ToSingleOrDefaultLocal(this object @this, float @default = default)
        {
            return ToSingleOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static float? ToSingleOrNullLocal(this object @this)
        {
            return ToSingleOrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToSingleLocal(this object @this, out float result)
        {
            return TryConvertToSingle(@this, CultureInfo.CurrentCulture, out result);
        }

        public static float ToFloatLocal(this object @this)
        {
            return ToSingleLocal(@this);
        }

        public static float ToFloatOrDefaultLocal(this object @this, float @default = default)
        {
            return ToSingleOrDefaultLocal(@this, @default);
        }

        public static float? ToFloatOrNullLocal(this object @this)
        {
            return ToSingleOrNullLocal(@this);
        }

        public static bool TryConvertToFloatLocal(this object @this, out float result)
        {
            return TryConvertToSingleLocal(@this, out result);
        }
    }
}
