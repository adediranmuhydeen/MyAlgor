// See https://aka.ms/new-console-template for more informat

using ConsoleApp1;


var time = Algorithms.Convert12HourTo24Hour("03:30 pm");
Console.WriteLine(TimeSpan.Parse(time));

TimeSpan span = new TimeSpan(19, 0, 0);

Console.WriteLine(DateTime.Parse(TimeOnly.FromTimeSpan(span).ToString()).ToString("t"));
int[] arr = {2, 7, 11, 15};
var result = LeetCode.TwoSum(arr, 9);
foreach (int i in arr)
{
    Console.WriteLine(i);
}