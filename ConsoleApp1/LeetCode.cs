﻿using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    public class LeetCode
    {
        //public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        //{
        //    int c = 0;
        //    for (int i = 0; i < nums1.Length; i++)
        //    {
                
        //        if (nums1[i] == 0 && c < n)
        //        {
        //            nums1[i] = nums2[c];
        //            c++;
        //        }
        //    }
        //    return nums1;
        //}

        //public int RemoveElement(int[] nums, int val)
        //{
        //    Array.Sort(nums);
        //    int q = nums.Length - 1;
        //    var result = nums.Where(x => x != val).ToArray();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == val)
        //        {
        //            nums[i] = nums[q];
        //            q--;
        //        }
        //    }
        //    return result.Length;
        //}

        //public int RemoveDuplicates(int[] nums)
        //{
        //    var temp = nums.Distinct().ToArray();
        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        nums[i] = temp[i];
        //    }
        //    return temp.Length;
        //}

        public static string GenerateId(string name, DateTime createdDate)
        {
            var _service = new List<string>{"EX2306232345", "EX2306234567"};
            string date = DateOnly.FromDateTime(createdDate).ToString("d");
            string Id = name.Substring(0, 2).ToUpper() + date.Substring(0, 2) + date.Substring(3, 2) + date.Substring(8, 2) + new Random().Next(1,9999).ToString("D5");

            if (_service.Contains(Id))
            {
                GenerateId(name, createdDate);
            }
            return Id;
        }


        /// <summary>
        /// Method to autogenerate  autoincrement alphanumeric codes, taking characters of specific length from the string supplied, and autoincrement the alphabeths from
        /// A to Z and the number from 1 to 9999
        /// </summary>
        /// <param name="name"></param>
        /// <param name="_service"></param>
        /// <param name="charLength"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        /// <returns></returns>

        public static string IdGenerator(string name, List<string> _service, int charLength, int firstIndex = 2, int secondIndex = 3)
        {
            int startIndex = 4;
            if (charLength > 2)
            {
                startIndex = startIndex + (charLength - 2);
            }
            int num = int.Parse(_service[_service.Count - 1].Substring(startIndex, 4));
            string myString = _service[_service.Count - 1];
            char firstChar = myString[firstIndex + (charLength - 2)];
            char secondChar = myString[secondIndex + (charLength - 2)];
            if (num + 1 > 9999)
            {
                secondChar = (char)(secondChar + 1);
                num = 0;
                if(secondChar > 'Z')
                {
                    firstChar = (char)(firstChar + 1);
                    secondChar = (char)(secondChar -26);

                    if(firstChar > 'Z')
                    {
                        firstChar = (char)(firstChar - 26);
                    }
                }
            }
            return name.Substring(0, charLength).ToUpper() + firstChar + secondChar + (num +1).ToString("D4");
        }

        /// <summary>
        /// Method to autogenerate  autoincrement alphanumeric codes, taking characters of specific length from the string supplied, and autoincrement the alphabeths from
        /// A to Z and the number from 1 to 9999 and Paded with another digit at the back
        /// </summary>
        /// <param name="name"></param>
        /// <param name="_service"></param>
        /// <param name="charLength"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        /// <returns></returns>

        public static string GenerateCode( List<string> _service, int length)
        {
            int intLength = length-2;
            
            int num = int.Parse(_service[_service.Count - 1].Substring(2, intLength));
            string myString = _service[_service.Count - 1];
            char firstChar = myString[0];
            char secondChar = myString[1];
            if (num + 1 > 99999)
            {
                secondChar = (char)(secondChar + 1);
                num = 0;
                if (secondChar > 'Z')
                {
                    firstChar = (char)(firstChar + 1);
                    secondChar = (char)(secondChar - 26);

                    if (firstChar > 'Z')
                    {
                        firstChar = (char)(firstChar - 26);                        
                    }
                }
            }
            var temp = (num + 1).ToString($"D{length-2}");
            return (firstChar.ToString() + secondChar.ToString() + temp );
        }

        public static string GenerateCodeID(string name, List<string> _service, int integerLenth,  int charLength = 4, int startIndex = 4)
        {
            var myString = _service.Count < 1 ? name.Substring(0, charLength) + (0).ToString($"D{integerLenth}") : _service[_service.Count - 1].Substring(0,charLength) != name.Substring(0, charLength)?name.Substring(0,charLength) + (0).ToString($"D{integerLenth}") : _service[_service.Count - 1];
           

            int num = int.Parse(myString.Substring(charLength));

            return (myString.Substring(0, charLength).ToUpper() + (num + 1).ToString($"D{integerLenth}"));
        }


        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            var res = new int[2];            
           for(int i = 0; i<nums.Length; i++)
            {
                var e = nums.Length - 1;
                while (i < nums.Length && e >= 0)
                {
                    if (nums[i] + nums[e] == target && i !=e)
                    {
                        res[0] = i;
                        res[1] = e;
                        break;
                    }
                    else
                    {
                        e--;
                    }
                }
            }
            return res;
        }

		/// <summary>
		/// Given a string s, find the length of the longest substring without repeating characters.
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		//public static int LengthOfLongestSubstring(string s)
		//{
		//    var result = 0;
		//    var output = 1;
		//    if (s.ToCharArray().Distinct().ToList().Count == s.Length)
		//    {
		//        return s.Length;
		//    }
		//    for (int i = 0; i < s.Length; i++)
		//    {
		//        var e = 1;
		//        while (e+i <= s.Length)
		//        {
		//            if (s.Substring(i, e).ToCharArray().Distinct().ToList().Count == s.Substring(i, e).Length)
		//            {
		//                result = s.Substring(i, e).Length > result ? s.Substring(i, e).Length : result;
		//                output = output>result ? output : result;
		//            }
		//            e++;
		//        }
		//    }
		//    return output;
		//}
		//public static int LengthOfLongestSubstring(string s)
		//{
		//	string holder = string.Empty;
		//	string result = "";
		//	int checker = 0;
		//	for (int i = 0; i < s.Length; i++)
		//	{
		//		checker += i;
		//		while (checker < s.Length)
		//		{
		//			if (s[i] == s[checker]  && )
		//			{
		//				holder = s.Substring(i, (checker - i));
		//				if (holder.Length > result.Length)
		//				{
		//					result = holder;
  //                          holder = string.Empty;
		//				}
		//			}
		//			checker++;
		//		}
		//		checker = 0;
		//	}
		//	return result.Length;
		//}
	}
}