using System;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static float ToSingle(this object @this, IFormatProvider provider)
        {
            return Convert.ToSingle(@this, provider);
        }

        public static float ToSingleOrDefault(this object @this, IFormatProvider provider, float @default = default)
        {
            bool isSingle = TryConvertToSingle(@this, provider, out float result);

            return isSingle ? result : @default;
        }

        public static float? ToSingleOrNull(this object @this, IFormatProvider provider)
        {
            if (@this is null)
            {
                return null;
            }

            bool isSingle = TryConvertToSingle(@this, provider, out float result);

            return isSingle ? (float?)result : null;
        }

        public static bool TryConvertToSingle(this object @this, IFormatProvider provider, out float result)
        {
            try
            {
                result = Convert.ToSingle(@this, provider);

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

        public static float ToFloat(this object @this, IFormatProvider provider)
        {
            return ToSingle(@this, provider);
        }

        public static float ToFloatOrDefault(this object @this, IFormatProvider provider, float @default = default)
        {
            return ToSingleOrDefault(@this, provider, @default);
        }

        public static float? ToFloatOrNull(this object @this, IFormatProvider provider)
        {
            return ToSingleOrNull(@this, provider);
        }

        public static bool TryConvertToFloat(this object @this, IFormatProvider provider, out float result)
        {
            return TryConvertToSingle(@this, provider, out result);
        }
    }
}
