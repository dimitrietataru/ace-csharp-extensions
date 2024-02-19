using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static float ToSingleLocal(this string @this)
        {
            return ToSingle(@this, CultureInfo.CurrentCulture);
        }

        public static float ToSingleOrDefaultLocal(this string @this, float @default = default)
        {
            return ToSingleOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static float? ToSingleOrNullLocal(this string @this)
        {
            return ToSingleOrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToSingleLocal(this string @this, out float result)
        {
            return TryConvertToSingle(@this, CultureInfo.CurrentCulture, out result);
        }

        public static float ToFloatLocal(this string @this)
        {
            return ToSingleLocal(@this);
        }

        public static float ToFloatOrDefaultLocal(this string @this, float @default = default)
        {
            return ToSingleOrDefaultLocal(@this, @default);
        }

        public static float? ToFloatOrNullLocal(this string @this)
        {
            return ToSingleOrNullLocal(@this);
        }

        public static bool TryConvertToFloatLocal(this string @this, out float result)
        {
            return TryConvertToSingleLocal(@this, out result);
        }
    }
}
