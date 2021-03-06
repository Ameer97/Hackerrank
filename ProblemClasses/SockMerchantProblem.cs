﻿using System;
using System.IO;
using System.Linq;

namespace Hackerrank.ProblemClasses
{
    class SockMerchantProblem
    {
        static int sockMerchant(int n, int[] ar)
        {
            var result = 0;
            foreach (var item in ar.Distinct().ToList())
                result += ar.ToList().Where(i => i == item).Count() / 2;
            return result;
        }

        public static void main()
        {
            var textWriter = new StreamWriter(@"C:\Users\Ameer\Desktop\result.txt");

            var n = Convert.ToInt32(Console.ReadLine());

            var ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
