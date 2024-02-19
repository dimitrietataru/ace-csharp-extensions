using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static double ToDoubleLocal(this string @this)
        {
            return ToDouble(@this, CultureInfo.CurrentCulture);
        }

        public static double ToDoubleOrDefaultLocal(this string @this, double @default = default)
        {
            return ToDoubleOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static double? ToDoubleOrNullLocal(this string @this)
        {
            return ToDoubleOrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToDoubleLocal(this string @this, out double result)
        {
            return TryConvertToDouble(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
