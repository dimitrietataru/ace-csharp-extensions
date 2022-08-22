using System;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static DateTime ToDateTime(this object @this, IFormatProvider provider)
        {
            return Convert.ToDateTime(@this, provider);
        }

        public static DateTime ToDateTimeOrDefault(this object @this, IFormatProvider provider, DateTime @default = default)
        {
            bool isDateTime = TryConvertToDateTime(@this, provider, out var result);

            return isDateTime ? result : @default;
        }

        public static bool TryConvertToDateTime(this object @this, IFormatProvider provider, out DateTime result)
        {
            try
            {
                result = Convert.ToDateTime(@this, provider);

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
        }
    }
}
