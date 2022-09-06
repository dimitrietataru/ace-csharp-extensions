using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static bool EqualsOrdinal(this string @this, string other)
        {
            return string.Equals(@this, other, StringComparison.Ordinal);
        }
    }
}
