using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ByteExtensions
    {
        public static string ToStringLocal(this byte @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }

        public static string ToStringLocal(this byte @this, string format)
        {
            return @this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
