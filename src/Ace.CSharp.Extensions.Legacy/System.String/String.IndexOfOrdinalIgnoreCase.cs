using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static int IndexOfOrdinalIgnoreCase(this string @this, string lookupValue)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return -1;
            }

            return @this.IndexOf(lookupValue, StringComparison.OrdinalIgnoreCase);
        }

        public static int IndexOfOrdinalIgnoreCase(this string @this, string lookupValue, int startIndex)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return -1;
            }

            return @this.IndexOf(lookupValue, startIndex, StringComparison.OrdinalIgnoreCase);
        }

        public static int IndexOfOrdinalIgnoreCase(this string @this, string lookupValue, int startIndex, int count)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return -1;
            }

            return @this.IndexOf(lookupValue, startIndex, count, StringComparison.OrdinalIgnoreCase);
        }
    }
}
