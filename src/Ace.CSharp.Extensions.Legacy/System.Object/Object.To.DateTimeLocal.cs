using System;
using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static DateTime ToDateTimeLocal(this object @this)
        {
            return ToDateTime(@this, CultureInfo.CurrentCulture);
        }

        public static DateTime ToDateTimeOrDefaultLocal(this object @this, DateTime @default = default)
        {
            return ToDateTimeOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static bool TryConvertToDateTimeLocal(this object @this, out DateTime result)
        {
            return TryConvertToDateTime(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
