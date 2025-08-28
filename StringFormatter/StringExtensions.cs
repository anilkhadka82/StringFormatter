using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StringFormatter
{
    public static class StringExtensions
    {
        public static string ToCommaSeparatedList(this string[] items)
        {
            if (items == null || items.Length < 1)
            { 
                return string.Empty;
            }
            return string.Join(",", items.Select(x => $"'{x}'"));
        }
    }
}
