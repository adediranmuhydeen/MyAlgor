using System;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;

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
            Console.WriteLine(positive.ToString());
            Console.WriteLine(negative.ToString());
            Console.WriteLine(nutral.ToString());
        }

        /// <summary>
        /// HackerLand University has the following grading policy: Every student receives a  in the inclusive range from 0 to 100. Any grade less than 40 is a failing grade. 
        /// Sam is a professor at the university and likes to round each student's  according to these rules:the difference between the grade and the next multiple of 5 is less than 3,
        /// round grade up to the next multiple of 5.If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                var byOne = grades[i]+1;
                var byTwo = grades[i] + 2;
                if (byOne % 5 == 0 && grades[i] > 37)
                {
                    result.Add(byOne);
                }
                else if (byTwo % 5 == 0 && grades[i] > 37)
                {
                    result.Add(byTwo);
                }
                else
                {
                    result.Add(grades[i]);
                }
            }

            return result;
        }


		/// <summary>
		/// Given an integer n and another integer k, repeat n in mutiple of k, and add all elements of the result together untill you get a single digit
		/// </summary>
		/// <param name="n"></param>
		/// <param name="k"></param>
		/// <returns></returns>
		public static int SumOfMultiple(int n, int k)
		{
			int result = 0;
			StringBuilder sb = new();
			for (int i = 0; i < k; i++)
			{
				sb.Append(n);
			}

			while (sb.Length > 1)
			{
				result = 0;
				foreach (char c in sb.ToString().ToCharArray())
				{
					result += int.Parse(c.ToString());
				}
				sb.Clear();
				sb.Append(result);
			}
			return result;

		}
		/// <summary>
		/// A Discrete Mathematics professor has a class of students. Frustrated with their lack of discipline, the professor decides to cancel class if fewer than 
        /// some number of students are present when class starts. Arrival times go from on time (arrivalTime<=0) to arrived late (arrivalTime>0).
        /// Given the arrival time of each student and a threshhold number of attendees, determine if the class is cancelled.
		/// </summary>
		/// <param name="k"></param>
		/// <param name="a"></param>
		/// <returns></returns>

		public static string angryProfessor(int k, List<int> a)
		{
			int result = 0;
			foreach (int b in a)
			{
				if (b <= 0)
				{
					result++;
				}
			}
			if (result < k) { return "YES"; } else { return "NO"; }
		}


		/// <summary>
		/// Lily likes to play games with integers. She has created a new game where she determines the difference between a number and its reverse. 
		/// For instance, given the number 12 , its reverse is 21. Their difference is 9. The number 120 reversed is 12, and their difference is 99.
		/// She decides to apply her game to decision making.She will look at a numbered range of days and will only go to a movie on a beautiful day.
		/// Function Description:	Complete the beautifulDays function in the editor below.
        /// beautifulDays has the following parameter(s) :
        /// int i: the starting day number
        /// int j: the ending day number
        /// int k: the divisor
		/// </summary>
		/// <param name="i"></param>
		/// <param name="j"></param>
		/// <param name="k"></param>
		/// <returns></returns>
		public static int beautifulDays(int i, int j, int k)
		{
			int count = 0;
			while (i <= j)
			{
				var reverse = i.ToString().ToCharArray();
				Array.Reverse(reverse);
				int reverseI = int.Parse(reverse);
				if ((i - reverseI) % k == 0)
				{
					count++;
				}
				i++;
			}
			return count;
		}

	}
}

