using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static ushort ToUInt16(this string @this, IFormatProvider provider)
        {
            return Convert.ToUInt16(@this, provider);
        }

        public static ushort ToUInt16OrDefault(this string @this, IFormatProvider provider, ushort @default = default)
        {
            bool isUInt16 = TryConvertToUInt16(@this, provider, out ushort result);

            return isUInt16 ? result : @default;
        }

        public static ushort? ToUInt16OrNull(this string @this, IFormatProvider provider)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return null;
            }

            bool isUInt16 = TryConvertToUInt16(@this, provider, out ushort result);

            return isUInt16 ? (ushort?)result : null;
        }

        public static bool TryConvertToUInt16(this string @this, IFormatProvider provider, out ushort result)
        {
            try
            {
                result = Convert.ToUInt16(@this, provider);

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
