using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class StringExtensions
    {
        public static string ReverseMe(this string s)
        {
            char[] arr = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            Array.ForEach(arr, x => stack.Push(x));

            return string.Join(string.Empty, stack);
        }

    }
}
