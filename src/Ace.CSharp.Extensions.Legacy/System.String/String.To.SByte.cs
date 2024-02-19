using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static sbyte ToSByte(this string @this, IFormatProvider provider)
        {
            return Convert.ToSByte(@this, provider);
        }

        public static sbyte ToSByteOrDefault(this string @this, IFormatProvider provider, sbyte @default = default)
        {
            bool isSByte = TryConvertToSByte(@this, provider, out sbyte result);

            return isSByte ? result : @default;
        }

        public static sbyte? ToSByteOrNull(this string @this, IFormatProvider provider)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return null;
            }

            bool isSByte = TryConvertToSByte(@this, provider, out sbyte result);

            return isSByte ? (sbyte?)result : null;
        }

        public static bool TryConvertToSByte(this string @this, IFormatProvider provider, out sbyte result)
        {
            try
            {
                result = Convert.ToSByte(@this, provider);

                return true;
            }
            catch (FormatException)
            {
                result = default;

                return false;
            }
            catch (ArgumentNullException)
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
