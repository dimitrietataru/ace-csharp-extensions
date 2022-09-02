using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static long ToInt64Invariant(this object @this)
        {
            return ToInt64(@this, CultureInfo.InvariantCulture);
        }

        public static long ToInt64OrDefaultInvariant(this object @this, long @default = default)
        {
            return ToInt64OrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool TryConvertToInt64Invariant(this object @this, out long result)
        {
            return TryConvertToInt64(@this, CultureInfo.InvariantCulture, out result);
        }

        public static long ToLongLocalInvariant(this object @this)
        {
            return ToInt64Invariant(@this);
        }

        public static long ToLongOrDefaultInvariant(this object @this, long @default = default)
        {
            return ToInt64OrDefaultInvariant(@this, @default);
        }

        public static bool TryConvertToLongInvariant(this object @this, out long result)
        {
            return TryConvertToInt64Invariant(@this, out result);
        }
    }
}
