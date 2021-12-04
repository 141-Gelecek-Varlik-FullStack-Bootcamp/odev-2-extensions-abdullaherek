using System;

namespace Odev2_Core
{
    public static class Extensions
    {
        public static string ToTurkishDateTime(this DateTime _variable)
        {
            return _variable.AddHours(value: 5).ToLongTimeString();
        }
    }
}
