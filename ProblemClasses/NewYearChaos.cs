using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank.ProblemClasses
{
    public class NewYearChaos
    {
        static string minimumBribes(int[] q)
        {
            int steps = 0;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                    return "Too chaotic";
                
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i]) 
                        steps++;
                }
            }
            return steps.ToString();
        }

        public static void main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            var Result = "";
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                Result += minimumBribes(q) + Environment.NewLine;
            }
            Console.WriteLine(Result.Substring(0,Result.Length - 1));
        }

    }
}
