using System;
using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class DateTimeExtensions
    {
        public static string ToStringInvariant(this DateTime @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this DateTime @this, string format)
        {
            return @this.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
