using System.Numerics;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    public class HackerRank
    {
        /// <summary>
        /// Given a square matrix, calculate the absolute difference between the sums of its diagonals.
        /// Function description Complete the  function in the editor below. diagonalDifference takes the following parameter:
        /// Input Format: The first line contains a single integer, , the number of rows and columns in the square matrix.
        /// Each of the next  lines describes a row, , and consists of  space-separated integers.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>
        /// The difference between the sum of the two diagonals as positive number
        /// </returns>
        public static int DiagonalDifference(List<List<int>> arr)
        {
            var right = 0;
            var left = 0;
            var hold = arr.Count - 1;
            var secHold = 0;
            while (secHold < arr.Count && hold >= 0)
            {
                left += arr[secHold][secHold];
                right += arr[hold][secHold];
                secHold++;
                hold--;
            }
            if (left - right < 0)
            {
                return right - left;
            }
            return left - right;
        }

        /// <summary>
        /// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
        /// Print the decimal value of each fraction on a new line with  places after the decimal.
        /// Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, 
        /// though answers with absolute error of up to are acceptable.
        /// </summary>
        /// <param name="arr"></param>
        public static void PlusMinus(List<int> arr)
        {
            double plus = 0;
            double minus = 0;
            double zero = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    plus++;
                }
                else if (arr[i] < 0)
                {
                    minus++;
                }
                else
                {
                    zero++;
                }
            }
            double positive = plus / arr.Count;
            double negative = minus / arr.Count;
            double nutral = zero / arr.Count;
            Console.WriteLine(positive.ToString("D4"));
            Console.WriteLine(negative.ToString("D7"));
            Console.WriteLine(nutral.ToString("D7"));
        }
    }
}
