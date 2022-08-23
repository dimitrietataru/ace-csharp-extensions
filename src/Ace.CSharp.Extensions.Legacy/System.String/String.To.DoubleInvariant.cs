using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static double ToDoubleInvariant(this string @this)
        {
            return ToDouble(@this, CultureInfo.InvariantCulture);
        }

        public static double ToDoubleOrDefaultInvariant(this string @this, double @default = default)
        {
            return ToDoubleOrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool TryConvertToDoubleInvariant(this string @this, out double result)
        {
            return TryConvertToDouble(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
