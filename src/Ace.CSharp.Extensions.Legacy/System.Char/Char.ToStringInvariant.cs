using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class CharExtensions
    {
        public static string ToStringInvariant(this char @this)
        {
            return @this.ToString(CultureInfo.InvariantCulture);
        }
    }
}
