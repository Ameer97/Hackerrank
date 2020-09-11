using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hackerrank.ProblemClasses
{
    public class LeftRotation
    {
        static int[] rotLeft(int[] a, int d)
        {
            var Shifts = d % a.Length;
            var tempList = a.Skip(Shifts).ToList();
            tempList.AddRange(a.Take(Shifts));
            return tempList.ToArray();
        }

        public static void main()
        {
            TextWriter textWriter = new StreamWriter(Program.Save(nameof(LeftRotation)));

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
