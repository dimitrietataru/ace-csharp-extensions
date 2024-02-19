using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static byte ToByte(this string @this, IFormatProvider provider)
        {
            return Convert.ToByte(@this, provider);
        }

        public static byte ToByteOrDefault(this string @this, IFormatProvider provider, byte @default = default)
        {
            bool isByte = TryConvertToByte(@this, provider, out byte result);

            return isByte ? result : @default;
        }

        public static byte? ToByteOrNull(this string @this, IFormatProvider provider)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return null;
            }

            bool isByte = TryConvertToByte(@this, provider, out byte result);

            return isByte ? (byte?)result : null;
        }

        public static bool TryConvertToByte(this string @this, IFormatProvider provider, out byte result)
        {
            try
            {
                result = Convert.ToByte(@this, provider);

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
