using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static ushort ToUInt16Local(this string @this)
        {
            return ToUInt16(@this, CultureInfo.CurrentCulture);
        }

        public static ushort ToUInt16OrDefaultLocal(this string @this, ushort @default = default)
        {
            return ToUInt16OrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static ushort? ToUInt16OrNullLocal(this string @this)
        {
            return ToUInt16OrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToUInt16Local(this string @this, out ushort result)
        {
            return TryConvertToUInt16(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
