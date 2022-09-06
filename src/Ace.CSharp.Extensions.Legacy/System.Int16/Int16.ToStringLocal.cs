using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class Int16Extensions
    {
        public static string ToStringLocal(this short @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }

        public static string ToStringLocal(this short @this, string format)
        {
            return @this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
