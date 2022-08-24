using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static ushort ToUInt16Invariant(this object @this)
        {
            return ToUInt16(@this, CultureInfo.InvariantCulture);
        }

        public static ushort ToUInt16OrDefaultInvariant(this object @this, ushort @default = default)
        {
            return ToUInt16OrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static bool TryConvertToUInt16Invariant(this object @this, out ushort result)
        {
            return TryConvertToUInt16(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
