using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class FluentStringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string text)
        {
            return String.IsNullOrWhiteSpace(text);
        }

        public static bool IsNullOrWhiteSpaceOrDefault(this string text, string defaultString)
        {
            return String.IsNullOrWhiteSpace(text) || text == defaultString;
        }
    }
}
