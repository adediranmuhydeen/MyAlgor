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