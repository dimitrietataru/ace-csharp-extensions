using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class Int16Extensions
    {
        public static string ToStringInvariant(this short @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }

        public static string ToStringInvariant(this short @this, string format)
        {
            return @this.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
