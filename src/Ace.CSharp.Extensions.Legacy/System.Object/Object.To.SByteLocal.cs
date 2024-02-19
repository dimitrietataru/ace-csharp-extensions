using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static sbyte ToSByteLocal(this object @this)
        {
            return ToSByte(@this, CultureInfo.CurrentCulture);
        }

        public static sbyte ToSByteOrDefaultLocal(this object @this, sbyte @default = default)
        {
            return ToSByteOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static sbyte? ToSByteOrNullLocal(this object @this)
        {
            return ToSByteOrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToSByteLocal(this object @this, out sbyte result)
        {
            return TryConvertToSByte(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
