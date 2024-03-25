using System;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(n => n)
                .ToArray();

            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                int secondIndex = Array.IndexOf(nums, complement);

                if (secondIndex != -1)
                {
                    Console.WriteLine($"{i}, {secondIndex}");
                    break;
                }
            }
            Console.WriteLine("No solution found.");
        }
    }
}
