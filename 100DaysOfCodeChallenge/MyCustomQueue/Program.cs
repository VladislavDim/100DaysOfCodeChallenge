namespace CustomQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCustomQueue<int> myCustomQueue = new MyCustomQueue<int>();

            int[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                myCustomQueue.Enqueue(input[i]);
            }

            while (!myCustomQueue.IsEmpty())
            {
                Console.WriteLine(myCustomQueue.Dequeue());
            }

        }
    }
}
