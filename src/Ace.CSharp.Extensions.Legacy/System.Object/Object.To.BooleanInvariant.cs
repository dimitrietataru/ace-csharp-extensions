using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static bool ToBooleanInvariant(this object @this)
        {
            return ToBoolean(@this, CultureInfo.InvariantCulture);
        }

        public static bool ToBooleanOrDefaultInvariant(this object @this, bool @default = default)
        {
            return ToBooleanOrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool? ToBooleanOrNullInvariant(this object @this)
        {
            return ToBooleanOrNull(@this, CultureInfo.InvariantCulture);
        }

        public static bool TryConvertToBooleanInvariant(this object @this, out bool result)
        {
            return TryConvertToBoolean(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
