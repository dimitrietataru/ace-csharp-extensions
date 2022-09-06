using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class Int64Extensions
    {
        public static string ToStringLocal(this long @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }

        public static string ToStringLocal(this long @this, string format)
        {
            return @this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
