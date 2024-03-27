namespace PeakElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (input[mid] < input[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;    
                }
            }

            Console.WriteLine(input[left]);

        }
    }
}
