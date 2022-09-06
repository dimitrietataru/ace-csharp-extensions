using System;
using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class DateTimeExtensions
    {
        public static string ToStringLocal(this DateTime @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }

        public static string ToStringLocal(this DateTime @this, string format)
        {
            return @this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
