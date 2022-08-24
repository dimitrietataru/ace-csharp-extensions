using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static ushort ToUInt16Invariant(this string @this)
        {
            return ToUInt16(@this, CultureInfo.InvariantCulture);
        }

        public static ushort ToUInt16OrDefaultInvariant(this string @this, ushort @default = default)
        {
            return ToUInt16OrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool TryConvertToUInt16Invariant(this string @this, out ushort result)
        {
            return TryConvertToUInt16(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
