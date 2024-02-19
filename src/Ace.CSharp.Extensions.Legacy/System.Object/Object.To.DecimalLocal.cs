using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static decimal ToDecimalLocal(this object @this)
        {
            return ToDecimal(@this, CultureInfo.CurrentCulture);
        }

        public static decimal ToDecimalOrDefaultLocal(this object @this, decimal @default = default)
        {
            return ToDecimalOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static decimal? ToDecimalOrNullLocal(this object @this)
        {
            return ToDecimalOrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToDecimalLocal(this object @this, out decimal result)
        {
            return TryConvertToDecimal(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
