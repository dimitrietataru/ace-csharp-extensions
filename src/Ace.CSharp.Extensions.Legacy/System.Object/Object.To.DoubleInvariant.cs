using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static double ToDoubleInvariant(this object @this)
        {
            return ToDouble(@this, CultureInfo.InvariantCulture);
        }

        public static double ToDoubleOrDefaultInvariant(this object @this, double @default = default)
        {
            return ToDoubleOrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static double? ToDoubleOrNullInvariant(this object @this)
        {
            return ToDoubleOrNull(@this, CultureInfo.InvariantCulture);
        }

        public static bool TryConvertToDoubleInvariant(this object @this, out double result)
        {
            return TryConvertToDouble(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
