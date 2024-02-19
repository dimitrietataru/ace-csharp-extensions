using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static int ToInt32Invariant(this string @this)
        {
            return ToInt32(@this, CultureInfo.InvariantCulture);
        }

        public static int ToInt32OrDefaultInvariant(this string @this, int @default = default)
        {
            return ToInt32OrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static int? ToInt32OrNullInvariant(this string @this)
        {
            return ToInt32OrNull(@this, CultureInfo.InvariantCulture);
        }

        public static bool TryConvertToInt32Invariant(this string @this, out int result)
        {
            return TryConvertToInt32(@this, CultureInfo.InvariantCulture, out result);
        }

        public static int ToIntInvariant(this string @this)
        {
            return ToInt32Invariant(@this);
        }

        public static int ToIntOrDefaultInvariant(this string @this, int @default = default)
        {
            return ToInt32OrDefaultInvariant(@this, @default);
        }

        public static int? ToIntOrNullInvariant(this string @this)
        {
            return ToInt32OrNullInvariant(@this);
        }

        public static bool TryConvertToIntInvariant(this string @this, out int result)
        {
            return TryConvertToInt32Invariant(@this, out result);
        }
    }
}
