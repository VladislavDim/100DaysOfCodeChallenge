namespace RotateArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (i + n + 1 <= array.Length)
                {
                    newArray[i] = array[i + n + 1];
                }
                newArray[n + 1] = array[i];

            }
            Console.WriteLine(string.Join(", ", newArray));
        }
    }
}
