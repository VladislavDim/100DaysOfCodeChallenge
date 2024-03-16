using System.Text;

namespace PalindromeChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Console.WriteLine("Write your word.");

            while ((input = Console.ReadLine()) != "End")
            {
                Console.WriteLine(CheckForPalindeome(input));
                Console.WriteLine("Write your word.");
            }

        }

        private static bool CheckForPalindeome(string input)
        {
            StringBuilder reversеdWord = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversеdWord.Append(input[i]);
            }

            return input == reversеdWord.ToString();
        }
    }
}
