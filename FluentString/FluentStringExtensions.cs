using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class FluentStringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        public static bool IsNullOrWhiteSpaceOrDefault(this string value, string defaultValue)
        {
            return String.IsNullOrWhiteSpace(value) || value == defaultValue;
        }
    }
}
