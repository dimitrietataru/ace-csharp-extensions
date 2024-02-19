using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static long ToInt64Local(this object @this)
        {
            return ToInt64(@this, CultureInfo.CurrentCulture);
        }

        public static long ToInt64OrDefaultLocal(this object @this, long @default = default)
        {
            return ToInt64OrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static long? ToInt64OrNullLocal(this object @this)
        {
            return ToInt64OrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToInt64Local(this object @this, out long result)
        {
            return TryConvertToInt64(@this, CultureInfo.CurrentCulture, out result);
        }

        public static long ToLongLocal(this object @this)
        {
            return ToInt64Local(@this);
        }

        public static long ToLongOrDefaultLocal(this object @this, long @default = default)
        {
            return ToInt64OrDefaultLocal(@this, @default);
        }

        public static long? ToLongOrNullLocal(this object @this)
        {
            return ToInt64OrNullLocal(@this);
        }

        public static bool TryConvertToLongLocal(this object @this, out long result)
        {
            return TryConvertToInt64Local(@this, out result);
        }
    }
}
