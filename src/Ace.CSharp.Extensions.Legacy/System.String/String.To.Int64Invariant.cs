using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static long ToInt64Invariant(this string @this)
        {
            return ToInt64(@this, CultureInfo.InvariantCulture);
        }

        public static long ToInt64OrDefaultInvariant(this string @this, long @default = default)
        {
            return ToInt64OrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool TryConvertToInt64Invariant(this string @this, out long result)
        {
            return TryConvertToInt64(@this, CultureInfo.InvariantCulture, out result);
        }

        public static long ToLongLocalInvariant(this string @this)
        {
            return ToInt64Invariant(@this);
        }

        public static long ToLongOrDefaultInvariant(this string @this, long @default = default)
        {
            return ToInt64OrDefaultInvariant(@this, @default);
        }

        public static bool TryConvertToLongInvariant(this string @this, out long result)
        {
            return TryConvertToInt64Invariant(@this, out result);
        }
    }
}
