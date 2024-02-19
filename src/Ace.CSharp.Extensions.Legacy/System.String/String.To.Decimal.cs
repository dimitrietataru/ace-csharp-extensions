using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static decimal ToDecimal(this string @this, IFormatProvider provider)
        {
            return Convert.ToDecimal(@this, provider);
        }

        public static decimal ToDecimalOrDefault(this string @this, IFormatProvider provider, decimal @default = default)
        {
            bool isDecimal = TryConvertToDecimal(@this, provider, out decimal result);

            return isDecimal ? result : @default;
        }

        public static decimal? ToDecimalOrNull(this string @this, IFormatProvider provider)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return null;
            }

            bool isDecimal = TryConvertToDecimal(@this, provider, out decimal result);

            return isDecimal ? (decimal?)result : null;
        }

        public static bool TryConvertToDecimal(this string @this, IFormatProvider provider, out decimal result)
        {
            try
            {
                result = Convert.ToDecimal(@this, provider);

                return true;
            }
            catch (FormatException)
            {
                result = default;

                return false;
            }
            catch (OverflowException)
            {
                result = default;

                return false;
            }
        }
    }
}
