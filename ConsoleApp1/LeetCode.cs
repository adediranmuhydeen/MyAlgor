namespace ConsoleApp1
{
    public class LeetCode
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int c = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                
                if (nums1[i] == 0 && c < n)
                {
                    nums1[i] = nums2[c];
                    c++;
                }
            }
            return nums1;
        }

        public int RemoveElement(int[] nums, int val)
        {
            Array.Sort(nums);
            int q = nums.Length - 1;
            var result = nums.Where(x => x != val).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[q];
                    q--;
                }
            }
            return result.Length;
        }

        public int RemoveDuplicates(int[] nums)
        {
            var temp = nums.Distinct().ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                nums[i] = temp[i];
            }
            return temp.Length;
        }
        public static string GenerateId(string name, DateTime createdDate)
        {
            var _service = new List<string> 
            {
                "EX2306232345", "EX2306234567"
            };
            string date = DateOnly.FromDateTime(createdDate).ToString("d");
            string Id = name.Substring(0, 2).ToUpper() + date.Substring(0, 2) + date.Substring(3, 2) + date.Substring(8, 2) + new Random().Next(10000).ToString();

            if (_service.Contains(Id))
            {
                GenerateId(name, createdDate);
            }
            return Id;
        }
    }
    
}
