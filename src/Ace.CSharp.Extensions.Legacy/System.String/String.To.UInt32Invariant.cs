using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static uint ToUInt32Invariant(this string @this)
        {
            return ToUInt32(@this, CultureInfo.InvariantCulture);
        }

        public static uint ToUInt32OrDefaultInvariant(this string @this, uint @default = default)
        {
            return ToUInt32OrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static uint? ToUInt32OrNullInvariant(this string @this)
        {
            return ToUInt32OrNull(@this, CultureInfo.InvariantCulture);
        }

        public static bool TryConvertToUInt32Invariant(this string @this, out uint result)
        {
            return TryConvertToUInt32(@this, CultureInfo.InvariantCulture, out result);
        }

        public static uint ToUIntInvariant(this string @this)
        {
            return ToUInt32Invariant(@this);
        }

        public static uint ToUIntOrDefaultInvariant(this string @this, uint @default = default)
        {
            return ToUInt32OrDefaultInvariant(@this, @default);
        }

        public static uint? ToUIntOrNullInvariant(this string @this)
        {
            return ToUInt32OrNullInvariant(@this);
        }

        public static bool TryConvertToUIntInvariant(this string @this, out uint result)
        {
            return TryConvertToUInt32Invariant(@this, out result);
        }
    }
}
