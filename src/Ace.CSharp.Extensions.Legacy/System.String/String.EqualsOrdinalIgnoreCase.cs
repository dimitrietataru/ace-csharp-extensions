using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static bool EqualsOrdinalIgnoreCase(this string @this, string other)
        {
            return string.Equals(@this, other, StringComparison.OrdinalIgnoreCase);
        }
    }
}
