using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class UInt64Extensions
    {
        public static string ToStringInvariant(this ulong @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this ulong @this, string format)
        {
            return @this.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
