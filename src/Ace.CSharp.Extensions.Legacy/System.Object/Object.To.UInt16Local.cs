using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static ushort ToUInt16Local(this object @this)
        {
            return ToUInt16(@this, CultureInfo.CurrentCulture);
        }

        public static ushort ToUInt16OrDefaultLocal(this object @this, ushort @default = default)
        {
            return ToUInt16OrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static ushort? ToUInt16OrNullLocal(this object @this)
        {
            return ToUInt16OrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToUInt16Local(this object @this, out ushort result)
        {
            return TryConvertToUInt16(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
