
using System.Text;

namespace ConsoleApp1
{
    public static class CodeWars
    {
        //You are given an odd-length array of integers, in which all of them are the same, except for one single number.
        //Complete the method which accepts such an array, and returns that single different number.
        public static int Stray(int[] numbers)
        {
            var r = numbers[1];
            return numbers.FirstOrDefault(x => x != r);
        }


        /// <summary>
        /// Input Strings a and b: For every character in string a swap the casing of every occurrence of the same character in string b.
        /// Then do the same casing swap with the inputs reversed. Return a single string consisting of the changed version of a followed 
        /// by the changed version of b. A char of a is in b regardless if it's in upper or lower case - see the testcases too.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string workOnStrings(string a, string b)
        {
           
            var res = string.Empty;
           
          return res;
        }

        public static List<int> BubbleSort(List<int> numbers)
        {
            return default;
        }


        /// <summary>
        /// Narcissistic number is any positive number whose sum of its own digit each raised to the power of digits in a given base is equal o that same number.
        /// Example:
        ///     Take 153(3 digits), which is a narcissistic number
        ///     1^3 + 5^3 + 3^3 = 153
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Narcissistic(int value)
        {
            string myStr = value.ToString();
            int bas = myStr.Length;
            int res = 0;
            foreach(char c in myStr) 
            {
                res += (int)Math.Pow((int)c-48, bas);
            }
            return res == value;
        }

        /// <summary>
        /// Convert dash separated string to camel case
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCamelCase(string str)
        {
            string[] temp = str.Split('-');
            StringBuilder sb = new StringBuilder();
            foreach(string s in temp)
            {
                if(s == temp[0])
                    sb.Append(s);
                else sb.Append(Capitalize(s));
            }
            return sb.ToString();
        }

        /// <summary>
        /// capitalize string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string Capitalize(string str)
        {
            string res = "";
            foreach (char c in str)
            {
                if (c == str[0])
                {
                    res += c.ToString().ToUpper();
                }
                else
                {
                    res += c;
                }
            }
            return res;
        }

		/// <summary>
		/// Count character in string: The main idea is to count all the occurring characters in a string. If you have a string like aba,
		/// then the result should be {'a': 2, 'b': 1}. What if the string is empty? Then the result should be empty object literal, {}.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static Dictionary<char, int> CountChar(string str)
		{
			var result = new Dictionary<char, int>();
			var strList = str.ToCharArray().Distinct().ToList();
			var myStrList = str.ToCharArray().ToList();
			for (int i = 0; i < strList.Count; i++)
			{
				int val = 0;
				foreach (char c in myStrList)
				{
					if (strList[i] == c)
					{
						val++;
					}
				}
				result.Add(strList[i], val);
			}
			return result;
		}

		public static Dictionary<char, int> Count(string str)
		{
			return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
		}
		/// <summary>
		/// Return the number (count) of vowels in the given string.We will consider a, e, i, o, u as vowels for this Kata(but not y).
        /// The input string will only consist of lower case letters and/or spaces.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static int GetVowelCount(string str)
		{
			var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
			return str.ToCharArray().Where(x => vowels.Contains(x)).Count();
		}
	}
}
