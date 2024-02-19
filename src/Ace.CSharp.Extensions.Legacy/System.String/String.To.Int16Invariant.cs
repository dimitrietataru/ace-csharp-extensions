using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static short ToInt16Invariant(this string @this)
        {
            return ToInt16(@this, CultureInfo.InvariantCulture);
        }

        public static short ToInt16OrDefaultInvariant(this string @this, short @default = default)
        {
            return ToInt16OrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static short? ToInt16OrNullInvariant(this string @this)
        {
            return ToInt16OrNull(@this, CultureInfo.InvariantCulture);
        }

        public static bool TryConvertToInt16Invariant(this string @this, out short result)
        {
            return TryConvertToInt16(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
