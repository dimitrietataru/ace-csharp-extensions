using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static double ToDoubleLocal(this object @this)
        {
            return ToDouble(@this, CultureInfo.CurrentCulture);
        }

        public static double ToDoubleOrDefaultLocal(this object @this, double @default = default)
        {
            return ToDoubleOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static bool TryConvertToDoubleLocal(this object @this, out double result)
        {
            return TryConvertToDouble(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
