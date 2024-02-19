using System.Globalization;

namespace Ace.CSharp.Extensions
{
    public static partial class ObjectExtensions
    {
        public static int ToInt32Local(this object @this)
        {
            return ToInt32(@this, CultureInfo.CurrentCulture);
        }

        public static int ToInt32OrDefaultLocal(this object @this, int @default = default)
        {
            return ToInt32OrDefault(@this, CultureInfo.CurrentCulture, @default);
        }

        public static int? ToInt32OrNullLocal(this object @this)
        {
            return ToInt32OrNull(@this, CultureInfo.CurrentCulture);
        }

        public static bool TryConvertToInt32Local(this object @this, out int result)
        {
            return TryConvertToInt32(@this, CultureInfo.CurrentCulture, out result);
        }

        public static int ToIntLocal(this object @this)
        {
            return ToInt32Local(@this);
        }

        public static int ToIntOrDefaultLocal(this object @this, int @default = default)
        {
            return ToInt32OrDefaultLocal(@this, @default);
        }

        public static int? ToIntOrNullLocal(this object @this)
        {
            return ToInt32OrNullLocal(@this);
        }

        public static bool TryConvertToIntLocal(this object @this, out int result)
        {
            return TryConvertToInt32Local(@this, out result);
        }
    }
}
