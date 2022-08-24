using System;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static ushort ToUInt16(this object @this, IFormatProvider provider)
        {
            return Convert.ToUInt16(@this, provider);
        }

        public static ushort ToUInt16OrDefault(this object @this, IFormatProvider provider, ushort @default = default)
        {
            bool isUInt16 = TryConvertToUInt16(@this, provider, out ushort result);

            return isUInt16 ? result : @default;
        }

        public static bool TryConvertToUInt16(this object @this, IFormatProvider provider, out ushort result)
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
