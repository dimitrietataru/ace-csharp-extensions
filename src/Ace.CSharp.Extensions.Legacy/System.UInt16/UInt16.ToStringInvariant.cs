using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class UInt16Extensions
    {
        public static string ToStringInvariant(this ushort @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this ushort @this, string format)
        {
            return @this.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
