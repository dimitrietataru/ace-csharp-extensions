using System;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static decimal ToDecimal(this object @this, IFormatProvider provider)
        {
            return Convert.ToDecimal(@this, provider);
        }

        public static decimal ToDecimalOrDefault(this object @this, IFormatProvider provider, decimal @default = default)
        {
            bool isDecimal = TryConvertToDecimal(@this, provider, out decimal result);

            return isDecimal ? result : @default;
        }

        public static decimal? ToDecimalOrNull(this object @this, IFormatProvider provider)
        {
            if (@this is null)
            {
                return null;
            }

            bool isDecimal = TryConvertToDecimal(@this, provider, out decimal result);

            return isDecimal ? (decimal?)result : null;
        }

        public static bool TryConvertToDecimal(this object @this, IFormatProvider provider, out decimal result)
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
