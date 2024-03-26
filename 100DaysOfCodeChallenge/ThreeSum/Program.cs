using System.Security.Cryptography;

namespace ThreeSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(n => n)
            .ToArray();

            List<string> uniqueTriplets = new List<string>();
            int n = nums.Length;

            for (int i = 0; i < n - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int target = -nums[i];

                int right = n - 1;
                int left = i + 1;


                while (left < right)
                {
                    int sum = nums[left] + nums[right];

                    if (sum == target)
                    {
                        uniqueTriplets.Add($"{nums[i]}, {nums[left]}, {nums[right]}");

                        // Skip duplicates
                        while (left < right && nums[left] == nums[left + 1])
                            left++;

                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            foreach (var triplet in uniqueTriplets)
            {
                Console.WriteLine(triplet);
            }
        }
    }
}
