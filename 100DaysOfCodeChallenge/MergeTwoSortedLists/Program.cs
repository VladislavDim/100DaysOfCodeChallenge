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

            int i = 0, j = 0;

            while (i < firstList.Count && j < secondList.Count)
            {
                if (firstList[i] < secondList[j])
                {
                    mergedList.Add(firstList[i]);
                    i++;
                }
                else
                {
                    mergedList.Add(secondList[j]);
                    j++;
                }
            }

            while (i < firstList.Count)
            {
                mergedList.Add(firstList[i]);
                i++;
            }

            while (j < secondList.Count)
            {
                mergedList.Add(secondList[j]);
                j++;
            }

            Console.WriteLine(String.Join("->", mergedList));
        }
    }
}
