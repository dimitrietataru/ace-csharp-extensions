using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static bool StartsWithOrdinal(this string @this, string lookupValue)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return false;
            }

            return @this.StartsWith(lookupValue, StringComparison.Ordinal);
        }
    }
}
