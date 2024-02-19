using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static short ToInt16(this string @this, IFormatProvider provider)
        {
            return Convert.ToInt16(@this, provider);
        }

        public static short ToInt16OrDefault(this string @this, IFormatProvider provider, short @default = default)
        {
            bool isInt16 = TryConvertToInt16(@this, provider, out short result);

            return isInt16 ? result : @default;
        }

        public static short? ToInt16OrNull(this string @this, IFormatProvider provider)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return null;
            }

            bool isInt16 = TryConvertToInt16(@this, provider, out short result);

            return isInt16 ? (short?)result : null;
        }

        public static bool TryConvertToInt16(this string @this, IFormatProvider provider, out short result)
        {
            try
            {
                result = Convert.ToInt16(@this, provider);

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
