// See https://aka.ms/new-console-template for more informat

using ConsoleApp1;


var time = Algorithms.Convert12HourTo24Hour("03:30 pm");
Console.WriteLine(TimeSpan.Parse(time));

TimeSpan span = new TimeSpan(19, 0, 0);

Console.WriteLine(DateTime.Parse(TimeOnly.FromTimeSpan(span).ToString()).ToString("t"));
int[] arr = {3,2,4};
var result = LeetCode.TwoSum(arr, 6);
foreach (int i in result)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------Length of longest substring---------");

Console.WriteLine(LeetCode.LengthOfLongestSubstring("aabbbbbuuuuuutrtfgdggd"));

List<List<int>> list = [[11, 2, 4,], [4, 5, 6], [10, 8, -12]];

Console.WriteLine(HackerRank.DiagonalDifference(list));

List<int> myList = [1, 0, -1];

HackerRank.PlusMinus(myList);

List<int> anotherList = [4, 73, 67, 38, 33];
var res = HackerRank.gradingStudents(anotherList);
foreach (int a in res)
{
    Console.WriteLine(a);
}