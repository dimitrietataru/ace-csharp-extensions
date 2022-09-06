using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class SingleExtensions
    {
        public static string ToStringInvariant(this float @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this float @this, string format)
        {
            return @this.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
