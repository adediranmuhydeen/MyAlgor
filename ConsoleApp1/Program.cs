// See https://aka.ms/new-console-template for more informat

using ConsoleApp1;
using System.Text;
using System.Text.RegularExpressions;


//var time = Algorithms.Convert12HourTo24Hour("03:30 pm");
//Console.WriteLine(TimeSpan.Parse(time));

//TimeSpan span = new TimeSpan(19, 0, 0);

//Console.WriteLine(DateTime.Parse(TimeOnly.FromTimeSpan(span).ToString()).ToString("t"));
//int[] arr = {3,2,4};
//var result = LeetCode.TwoSum(arr, 6);
//foreach (int i in result)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("---------Length of longest substring---------");

//Console.WriteLine(LeetCode.LengthOfLongestSubstring("bbbbbbb"));

//List<List<int>> list = [[11, 2, 4,], [4, 5, 6], [10, 8, -12]];

//Console.WriteLine(HackerRank.DiagonalDifference(list));

//List<int> myList = [1, 0, -1];

//HackerRank.PlusMinus(myList);

//List<int> anotherList = [4, 73, 67, 38, 33];
//var res = HackerRank.gradingStudents(anotherList);
//foreach (int a in res)
//{
//    Console.WriteLine(a);
//}

//Console.WriteLine((int)(Convert.ToDouble("23.578676876")));

//List<int> bubble = [20, 33, 25, 48, 17, 23, 31];

//var bubbleList = CodeWars.BubbleSort(bubble);

//foreach(int i in bubbleList)
//{
//    Console.WriteLine(i);
//}

//List<string> _codes = new() { "AA000001" };

//Console.WriteLine(LeetCode.GenerateCode(_codes, 8));
//string nameValidator = @"^[^±!@£$%^&*_+§¡€#¢§¶•ªº«\\/<>?:;|=.,0-9]{3,30}$";

//Console.WriteLine(Regex.IsMatch("Muhydeenmuhydeenmuhydeenmuhyde", nameValidator));

//Console.WriteLine(CodeWars.Narcissistic(153));

//Console.WriteLine(CodeWars.ToCamelCase("the-Man-is-a-Good-man"));

//char[] name = "muhydeen".ToCharArray();
//name[0] = Char.ToUpper(name[0]);

//Console.WriteLine(HackerRank.SaveThePrisoner(4,6,2));

string name = "Muhydee";
//Console.WriteLine(name.Substring(1,4));

var list = name.ToCharArray().Distinct().ToList();
Console.WriteLine(string.Join(',', list));





