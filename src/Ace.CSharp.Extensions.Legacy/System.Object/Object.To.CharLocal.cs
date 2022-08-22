using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static char ToCharLocal(this object @this)
        {
            return ToChar(@this, CultureInfo.CurrentCulture);
        }

        public static char ToCharOrDefaultLocal(this object @this, char @default = default)
        {
            return ToCharOrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static bool TryConvertToCharLocal(this object @this, out char result)
        {
            return TryConvertToChar(@this, CultureInfo.CurrentCulture, out result);
        }
    }
}
