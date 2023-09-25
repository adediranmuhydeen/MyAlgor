using System.Text;

namespace ConsoleApp1
{
    public class CodeWars
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
            StringBuilder sb = new StringBuilder();
            var res = a + b;
            for(int i=0; i<res.Length; i++)
            {
                if (a.Contains(res[i]) && b.Contains(res[i]))
                {
                    sb.Append(Char.ToUpper(res[i]));
                    b = b.Remove(i);
                }               
                else
                {
                    sb.Append(res[i]);
                    //res = res.Remove(res[i]);
                }
            }
            return sb.ToString();
        }
    }
}
