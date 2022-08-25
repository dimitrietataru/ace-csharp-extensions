using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static sbyte ToSByteLocal(this string @this)
        {
            return ToSByte(@this, CultureInfo.CurrentCulture);
        }

        public static sbyte ToSByteOrDefaultLocal(this string @this, sbyte @default = default)
        {
            return ToSByteOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static bool TryConvertToSByteLocal(this string @this, out sbyte result)
        {
            return TryConvertToSByte(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
