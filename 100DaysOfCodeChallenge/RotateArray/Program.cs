namespace RotateArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split(",")
                .Select(int.Parse));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int crnValue = queue.Dequeue();
                queue.Enqueue(crnValue);

            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
