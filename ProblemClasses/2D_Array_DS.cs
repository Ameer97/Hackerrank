using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hackerrank.ProblemClasses
{
    public class _2D_Array_DS
    {
        static int hourglassSum(int[][] arr)
        {
            var countResult = 0;
            int max = 0;
            for (int i = 0; i < arr.Length -2; i++)
            {
                for (int j = 0; j < arr[i].Length -2; j++)
                {
                    countResult = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (i == j && i == 0) max = countResult;
                    if (max < countResult) max = countResult;
                }
            }
            return max;
        }

        public static void main()
        {
            TextWriter textWriter = new StreamWriter(Program.Save(nameof(_2D_Array_DS)));

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Replace("  ", " ").Trim().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
