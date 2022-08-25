using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static sbyte ToSByteInvariant(this string @this)
        {
            return ToSByte(@this, CultureInfo.InvariantCulture);
        }

        public static sbyte ToSByteOrDefaultInvariant(this string @this, sbyte @default = default)
        {
            return ToSByteOrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool TryConvertToSByteInvariant(this string @this, out sbyte result)
        {
            return TryConvertToSByte(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
