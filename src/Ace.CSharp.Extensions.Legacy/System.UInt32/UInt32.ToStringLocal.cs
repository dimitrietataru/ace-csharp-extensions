using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class UInt32Extensions
    {
        public static string ToStringLocal(this uint @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }

        public static string ToStringLocal(this uint @this, string format)
        {
            return @this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
