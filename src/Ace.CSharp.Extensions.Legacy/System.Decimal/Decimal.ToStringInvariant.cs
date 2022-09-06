using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class DecimalExtensions
    {
        public static string ToStringInvariant(this decimal @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this decimal @this, string format)
        {
            return @this.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
