// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Text.Json;

//Console.WriteLine(TimeOnly.FromDateTime(DateTime.Now));
//Console.WriteLine(int.TryParse("4", out int number));
//int[] nums1 = {1, 2, 3, 0, 0, 0};
//int[] nums2 = { 2, 4, 5 };
//int n = 3;
//int m = 6;
////Span<string> sp = new Span<string>();
//Console.WriteLine(LeetCode.Merge(nums1,m, nums2, n)[1]);

////nums2.CopyTo(nums1, 0, );

//foreach (int i in nums1)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(DateTime.UtcNow);
//List<string> col = new() { "MUHY", "MMUHY", "ADEB", "AADEB", "MMUHYD"};
//var algo = new Algorithm(col, 4);

//Console.WriteLine(algo.CreateId("Muhydeen"));

//Console.WriteLine(DateOnly.FromDateTime(DateTime.UtcNow).ToString("d"));
Console.WriteLine(LeetCode.GenerateId("ExamRoom", DateTime.UtcNow));