using System;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static short ToInt16(this object @this, IFormatProvider provider)
        {
            return Convert.ToInt16(@this, provider);
        }

        public static short ToInt16OrDefault(this object @this, IFormatProvider provider, short @default = default)
        {
            bool isInt16 = TryConvertToInt16(@this, provider, out short result);

            return isInt16 ? result : @default;
        }

        public static short? ToInt16OrNull(this object @this, IFormatProvider provider)
        {
            if (@this is null)
            {
                return null;
            }

            bool isInt16 = TryConvertToInt16(@this, provider, out short result);

            return isInt16 ? (short?)result : null;
        }

        public static bool TryConvertToInt16(this object @this, IFormatProvider provider, out short result)
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
