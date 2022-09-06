using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class BooleanExtensions
    {
        public static string ToStringLocal(this bool @this)
        {
            return @this.ToString(CultureInfo.CurrentCulture);
        }
    }
}
