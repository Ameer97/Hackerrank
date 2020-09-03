using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hackerrank.ProblemClasses
{
    class CountingValleysProblem
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            var sArray = s.ToCharArray().ToList();
            var currentArrow = 0;
            var result = 0;
            foreach (var item in sArray)
            {
                if(item == 'D') 
                {
                    if (currentArrow == 0)
                        result += 1;
                    currentArrow += 1;
                }
                if (item == 'U')
                    currentArrow -= 1;
            }

            return result;
        }

        public static void main()
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\Ameer\Desktop\result2.txt");

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
