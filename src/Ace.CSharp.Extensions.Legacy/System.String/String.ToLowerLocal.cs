using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static string ToLowerLocal(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return @this;
            }

            return @this.ToLower(CultureInfo.CurrentCulture);
        }

        public static string ToLowerOrDefaultLocal(this string @this, string @default = "")
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return @default;
            }

            return @this.ToLower(CultureInfo.CurrentCulture);
        }
    }
}
