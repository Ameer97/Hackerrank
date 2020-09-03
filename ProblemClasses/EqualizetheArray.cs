using System;
using System.IO;
using System.Linq;

namespace Hackerrank.ProblemClasses
{
    class EqualizetheArray
    {
        static int equalizeArray(int[] arr)
        {
            var max = 0;
            var count = 0;
            foreach (var item in arr.Distinct().ToList())
            {
                count = arr.Where(a => a == item).Count();
                if (max < count)
                    max = count;
            }
            return arr.Length - max;
        }

        public static void main()
        {
            while (true)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
                Console.WriteLine(equalizeArray(arr));
            }
        }
    }

}
