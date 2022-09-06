using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class SingleExtensions
    {
        public static string ToStringLocal(this float @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }

        public static string ToStringLocal(this float @this, string format)
        {
            return @this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
