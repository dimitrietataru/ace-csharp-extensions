using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class DoubleExtensions
    {
        public static string ToStringInvariant(this double @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this double @this, string format)
        {
            return @this.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
