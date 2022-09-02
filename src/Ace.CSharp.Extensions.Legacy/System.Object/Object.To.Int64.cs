using System;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static long ToInt64(this object @this, IFormatProvider provider)
        {
            return Convert.ToInt64(@this, provider);
        }

        public static long ToInt64OrDefault(this object @this, IFormatProvider provider, long @default = default)
        {
            bool isInt64 = TryConvertToInt64(@this, provider, out long result);

            return isInt64 ? result : @default;
        }

        public static bool TryConvertToInt64(this object @this, IFormatProvider provider, out long result)
        {
            try
            {
                result = Convert.ToInt64(@this, provider);

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

        public static long ToLong(this object @this, IFormatProvider provider)
        {
            return ToInt64(@this, provider);
        }

        public static long ToLongOrDefault(this object @this, IFormatProvider provider, long @default = default)
        {
            return ToInt64OrDefault(@this, provider, @default);
        }

        public static bool TryConvertToLong(this object @this, IFormatProvider provider, out long result)
        {
            return TryConvertToInt64(@this, provider, out result);
        }
    }
}
