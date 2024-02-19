using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static sbyte ToSByteInvariant(this object @this)
        {
            return ToSByte(@this, CultureInfo.InvariantCulture);
        }

        public static sbyte ToSByteOrDefaultInvariant(this object @this, sbyte @default = default)
        {
            return ToSByteOrDefault(@this, CultureInfo.InvariantCulture, @default);
        }

        public static sbyte? ToSByteOrNullInvariant(this object @this)
        {
            return ToSByteOrNull(@this, CultureInfo.InvariantCulture);
        }

        public static bool TryConvertToSByteInvariant(this object @this, out sbyte result)
        {
            return TryConvertToSByte(@this, CultureInfo.InvariantCulture, out result);
        }
    }
}
