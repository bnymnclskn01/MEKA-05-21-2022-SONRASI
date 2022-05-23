using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.CheckEquality
{
    internal class check
    {
        public static bool checkEquality<T>(T[] first, T[] second)
        {
            return System.Linq.Enumerable.SequenceEqual(first, second);
        }
        public static void MainLeep()
        {
            int[] vs = { 1, 2, 3, 4, 5};
            int[] vs2 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] vs3 = { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12, };
            Console.WriteLine((checkEquality(vs, vs2)));
            Console.WriteLine((checkEquality(vs3, vs2)));
        }
    }
}
