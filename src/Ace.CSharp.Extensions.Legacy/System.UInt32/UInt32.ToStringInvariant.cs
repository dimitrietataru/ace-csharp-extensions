using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class UInt32Extensions
    {
        public static string ToStringInvariant(this uint @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this uint @this, string format)
        {
            return @this.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
