using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace MergeIntervals
{
    public class Program
    {
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> mergedIntervals = new List<int[]>();

            if (intervals.Length == 0)
                return mergedIntervals.ToArray();

            // Sort the intervals based on the start point
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            // Initialize variables for the current start and end points
            int start = intervals[0][0];
            int end = intervals[0][1];

            // Merge overlapping intervals
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= end) // Overlapping intervals
                {
                    end = Math.Max(end, intervals[i][1]);
                }
                else // Non-overlapping interval
                {
                    mergedIntervals.Add(new int[] { start, end });
                    start = intervals[i][0];
                    end = intervals[i][1];
                }
            }

            // Add the last merged interval
            mergedIntervals.Add(new int[] { start, end });

            return mergedIntervals.ToArray();
        }

        static void Main(string[] args)
        {
            int[][] intervals = Console.ReadLine()
                 .Trim('[', ']')
            .Split("],[", StringSplitOptions.RemoveEmptyEntries)
            .Select(pair => pair.Split(',')
                .Select(int.Parse)
                .ToArray())
            .ToArray();


            int[][] mergedIntervals = Merge(intervals);

            Console.WriteLine("Merged Intervals:");
            foreach (var interval in mergedIntervals)
            {
                Console.WriteLine($"[{interval[0]}, {interval[1]}]");
            }
        }
    }
}
