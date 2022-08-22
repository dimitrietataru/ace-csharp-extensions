using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static decimal ToDecimalInvariant(this string @this)
        {
            return ToDecimal(@this, CultureInfo.InvariantCulture);
        }

        public static decimal ToDecimalOrDefaultInvariant(this string @this, decimal @default = default)
        {
            return ToDecimalOrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool TryConvertToDecimalInvariant(this string @this, out decimal result)
        {
            return TryConvertToDecimal(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
