using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hackerrank.ProblemClasses
{
    public class RepeatedString
    {
        static long repeatedString(string s, long n)
        {
            var Repeated_a_InBlock = s.ToList().Where(i => i == 'a').Count();
            var FullRepeatedCount = n / s.Length;
            long Result = FullRepeatedCount * Repeated_a_InBlock;
            if (FullRepeatedCount * s.Length == n) return Result;

            var JustToThispartString = n - FullRepeatedCount * s.Length;
            return Result += s.Substring(0 , (int)JustToThispartString).ToList().Where(i => i == 'a').Count();
        }

        public static void main()
        {
            var textWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + nameof(RepeatedString) + ".txt");

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
