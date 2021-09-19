using System;
using System.Collections.Generic;
using System.Text;

namespace PTJK.OpenWeatherAPI.Helpers
{
    internal static class Ensure
    {
        public static void ArgumentNotNull(object value, string name)
        {
            if (value != null)
            {
                return;
            }

            throw new ArgumentNullException(name);
        }

        public static void ArgumentNotNullOrEmptyString(string value, string name)
        {
            ArgumentNotNull(value, name);
            if (!string.IsNullOrEmpty(value))
            {
                return;
            }

            throw new ArgumentException("String cannot be empty", name);
        }
    }
}
