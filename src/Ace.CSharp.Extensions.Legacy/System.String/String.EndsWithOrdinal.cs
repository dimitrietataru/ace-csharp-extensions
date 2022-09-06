using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static bool EndsWithOrdinal(this string @this, string lookupValue)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return false;
            }

            return @this.EndsWith(lookupValue, StringComparison.Ordinal);
        }
    }
}
