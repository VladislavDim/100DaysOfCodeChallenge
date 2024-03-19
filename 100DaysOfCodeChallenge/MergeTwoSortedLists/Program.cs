namespace MergeTwoSortedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToList();

            List<int> mergedList = new List<int>();

            int minLength = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < minLength; i++)
            {
                int minNum = Math.Min(firstList[i], secondList[i]);
                int maxNum = Math.Max(firstList[i], secondList[i]);

                mergedList.Add(minNum);
                mergedList.Add(maxNum);
            }

            if (firstList.Count > secondList.Count)
            {
                AddRemainingValues(firstList, mergedList, minLength);
            }
            else if (secondList.Count > firstList.Count)
            {
                AddRemainingValues(secondList, mergedList, minLength);
            }

            Console.WriteLine(String.Join("->", mergedList));
        }

        private static void AddRemainingValues(List<int> remainingValues, List<int> mergedList, int minLength)
        {
            for (int i = minLength; i < remainingValues.Count; i++)
            {
                mergedList.Add(remainingValues[i]);
            }
        }
    }
}
