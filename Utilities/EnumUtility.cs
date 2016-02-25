using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CERTIVAL.Utilities
{
    public static class EnumUtility
    {
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}