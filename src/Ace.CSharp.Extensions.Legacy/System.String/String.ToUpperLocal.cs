using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static string ToUpperLocal(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return @this;
            }

            return @this.ToUpper(CultureInfo.CurrentCulture);
        }

        public static string ToUpperOrDefaultLocal(this string @this, string @default = "")
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return @default;
            }

            return @this.ToUpper(CultureInfo.CurrentCulture);
        }
    }
}
