using System;
using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static DateTime ToDateTimeInvariant(this object @this)
        {
            return ToDateTime(@this, CultureInfo.InvariantCulture);
        }

        public static DateTime ToDateTimeOrDefaultInvariant(this object @this, DateTime @default = default)
        {
            return ToDateTimeOrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static DateTime? ToDateTimeOrNullInvariant(this object @this)
        {
            return ToDateTimeOrNull(@this, CultureInfo.InvariantCulture);
        }

        public static bool TryConvertToDateTimeInvariant(this object @this, out DateTime result)
        {
            return TryConvertToDateTime(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
