using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class UInt64Extensions
    {
        public static string ToStringLocal(this ulong @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }

        public static string ToStringLocal(this ulong @this, string format)
        {
            return @this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
