using System;
using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static DateTime ToDateTimeLocal(this string @this)
        {
            return ToDateTime(@this, CultureInfo.CurrentCulture);
        }

        public static DateTime ToDateTimeOrDefaultLocal(this string @this, DateTime @default = default)
        {
            return ToDateTimeOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static bool TryConvertToDateTimeLocal(this string @this, out DateTime result)
        {
            return TryConvertToDateTime(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
