using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubarrayWithSumK
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(FindLongestSubarrayWithSumK(nums, k));
        }

        static int FindLongestSubarrayWithSumK(int[] nums, int k)
        {
            int maxLen = 0;
            int currSum = 0;
            Dictionary<int, int> sumMap = new Dictionary<int, int>(); // Map to store cumulative sum and its index

            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];

                if (currSum == k)
                {
                    maxLen = Math.Max(maxLen, i + 1);
                }
                else if (sumMap.ContainsKey(currSum - k))
                {
                    maxLen = Math.Max(maxLen, i - sumMap[currSum - k]);
                }

                if (!sumMap.ContainsKey(currSum))
                {
                    sumMap[currSum] = i; // Store the cumulative sum and its index
                }
            }

            return maxLen;
        }
    }
}
