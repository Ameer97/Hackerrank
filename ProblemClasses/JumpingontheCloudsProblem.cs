using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hackerrank.ProblemClasses
{
    class JumpingontheCloudsProblem
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            var Steps = -1;
            for (int i = 0; i < c.Length; i++)
            {
                Steps += 1;
                if (i + 2 >= c.Length) continue;
                if (i + 1 >= c.Length) break;
                if (c[i + 2] == 0 || c[i + 1] == 1) i += 1;
            }
            return Steps;
        }

        public static void main()
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\Ameer\Desktop\result3.txt");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
