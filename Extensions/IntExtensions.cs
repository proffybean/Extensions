using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class IntExtensions
    {
        public static int NextInt(this int i)
        {
            return i + 1;
        }

        public static int PreviousInt(this int i)
        {
            return i - 1;
        }

        public static bool IsPerfectSquare(this int i)
        {
            double sqrt = Math.Sqrt((double)i);

            return Math.Floor(sqrt) == sqrt;
        }

        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }
    }
}
