using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class SByteExtensions
    {
        public static string ToStringLocal(this sbyte @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }

        public static string ToStringLocal(this sbyte @this, string format)
        {
            return @this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
