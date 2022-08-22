using System;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static byte ToByte(this object @this, IFormatProvider provider)
        {
            return Convert.ToByte(@this, provider);
        }

        public static byte ToByteOrDefault(this object @this, IFormatProvider provider, byte @default = default)
        {
            bool isByte = TryConvertToByte(@this, provider, out byte result);

            return isByte ? result : @default;
        }

        public static bool TryConvertToByte(this object @this, IFormatProvider provider, out byte result)
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
            catch (InvalidCastException)
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
