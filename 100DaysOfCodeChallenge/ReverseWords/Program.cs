namespace ReverseWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            Console.WriteLine(String.Join(" ", words.Reverse()));
        }
    }
}
