using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static int ToInt32Invariant(this object @this)
        {
            return ToInt32(@this, CultureInfo.InvariantCulture);
        }

        public static int ToInt32OrDefaultInvariant(this object @this, int @default = default)
        {
            return ToInt32OrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static int? ToInt32OrNullInvariant(this object @this)
        {
            return ToInt32OrNull(@this, CultureInfo.InvariantCulture);
        }

        public static bool TryConvertToInt32Invariant(this object @this, out int result)
        {
            return TryConvertToInt32(@this, CultureInfo.InvariantCulture, out result);
        }

        public static int ToIntInvariant(this object @this)
        {
            return ToInt32Invariant(@this);
        }

        public static int ToIntOrDefaultInvariant(this object @this, int @default = default)
        {
            return ToInt32OrDefaultInvariant(@this, @default);
        }

        public static int? ToIntOrNullInvariant(this object @this)
        {
            return ToInt32OrNullInvariant(@this);
        }

        public static bool TryConvertToIntInvariant(this object @this, out int result)
        {
            return TryConvertToInt32Invariant(@this, out result);
        }
    }
}
