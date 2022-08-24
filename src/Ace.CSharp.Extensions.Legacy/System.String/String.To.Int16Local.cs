using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static short ToInt16Local(this string @this)
        {
            return ToInt16(@this, CultureInfo.CurrentCulture);
        }

        public static short ToInt16OrDefaultLocal(this string @this, short @default = default)
        {
            return ToInt16OrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static bool TryConvertToInt16Local(this string @this, out short result)
        {
            return TryConvertToInt16(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
