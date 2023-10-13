// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Collections;
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

//int unicodeValue = (int)'y'; // Convert to Unicode value
//unicodeValue++; // Increment the value
//Console.WriteLine((char)unicodeValue);

//Console.WriteLine((char)(' ' + 1));


//Console.WriteLine(LeetCode.GenerateId("ExamRoom", DateTime.UtcNow));


//var _service = new List<string> { "EXAA0001", "EXAA9999", "EXAZ9999", "EXCZ9999", "UNIVERSDA0001" };

//Console.WriteLine(LeetCode.IdGenerator("University", _service, 7));

//var service = new List<string> { "EXAA0001A", "EXAA9999A", "EXAZ9999A", "EXZZ9999A", "TSEYZ9999B", "EXAMROOMZZ9999B" };

//Console.WriteLine(LeetCode.GenerateCode("TestSite", service, 8));

var x = new int[] {2, 1, 1};
var y = new int[] {1, 1, 1, 1, 1,2};
//var a = "Muhydeen";
//Console.WriteLine(CodeWars.Stray(x));
//Console.WriteLine(CodeWars.Stray(y));
//Console.WriteLine(CodeWars.workOnStrings("cabab", "bababa"));
//Console.WriteLine(CodeWars.workOnStrings("abc", "cde"));
//var f = "abab";
//var s = "bababa";
//HashSet<char> charF = new(f.ToCharArray());
//HashSet<char> chars = new(s.ToCharArray());
//charF.IntersectWith(chars);

//var t1 = DateTime.UtcNow;
//var t2 = DateTime.UtcNow.AddMinutes(30);
//var t3 = t1 - t2;
//Console.WriteLine((int)t3.TotalMinutes);

//ArrayList arrayList = new ArrayList();
//arrayList.Add(5);
//arrayList.Add('r');
//arrayList.Add("name");
//Console.WriteLine(arrayList[0]);

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}

//KeyValuePair<int, string> kvp = new();
//Dictionary<int, string> dict = new();
//dict.Add(1, "Name");
//dict.Add(2, "Email");
//dict.Add(3, "Phone Number");
//dict.Add(4, "Password");
List<string> list = new List<string>{ "RESC-00001","RESC-00002", "RESC-00003" };

DayOfTheWeekJob manager = new DayOfTheWeekJob();

Console.WriteLine(LeetCode.GenerateCodeID("RESc-",list,5,5));