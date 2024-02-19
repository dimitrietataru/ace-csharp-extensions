using System;

namespace Ace.CSharp.Extensions
{
    public static partial class StringExtensions
    {
        public static bool ToBoolean(this string @this, IFormatProvider provider)
        {
            return Convert.ToBoolean(@this, provider);
        }

        public static bool ToBooleanOrDefault(this string @this, IFormatProvider provider, bool @default = default)
        {
            bool isBoolean = TryConvertToBoolean(@this, provider, out bool result);

            return isBoolean ? result : @default;
        }

        public static bool? ToBooleanOrNull(this string @this, IFormatProvider provider)
        {
            if (string.IsNullOrWhiteSpace(@this))
            {
                return null;
            }

            bool isBoolean = TryConvertToBoolean(@this, provider, out bool result);

            return isBoolean ? (bool?)result : null;
        }

        public static bool TryConvertToBoolean(this string @this, IFormatProvider provider, out bool result)
        {
            try
            {
                result = Convert.ToBoolean(@this, provider);

                return true;
            }
            catch (FormatException)
            {
                result = default;

                return false;
            }
        }
    }
}
