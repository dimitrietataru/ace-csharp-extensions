using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static char ToCharLocal(this string @this)
        {
            return ToChar(@this, CultureInfo.CurrentCulture);
        }

        public static char ToCharOrDefaultLocal(this string @this, char @default = default)
        {
            return ToCharOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static char? ToCharOrNullLocal(this string @this)
        {
            return ToCharOrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToCharLocal(this string @this, out char result)
        {
            return TryConvertToChar(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
