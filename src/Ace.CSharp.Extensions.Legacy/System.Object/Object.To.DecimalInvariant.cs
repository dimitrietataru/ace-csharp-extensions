using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static decimal ToDecimalInvariant(this object @this)
        {
            return ToDecimal(@this, CultureInfo.InvariantCulture);
        }

        public static decimal ToDecimalOrDefaultInvariant(this object @this, decimal @default = default)
        {
            return ToDecimalOrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool TryConvertToDecimalInvariant(this object @this, out decimal result)
        {
            return TryConvertToDecimal(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
