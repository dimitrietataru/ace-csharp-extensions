using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static byte ToByteLocal(this string @this)
        {
            return ToByte(@this, CultureInfo.CurrentCulture);
        }

        public static byte ToByteOrDefaultLocal(this string @this, byte @default = default)
        {
            return ToByteOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static bool TryConvertToByteLocal(this string @this, out byte result)
        {
            return TryConvertToByte(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
