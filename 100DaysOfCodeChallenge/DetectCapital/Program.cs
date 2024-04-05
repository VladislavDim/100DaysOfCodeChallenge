
namespace DetectCapital
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(DetectCapital(input));
        }

        private static bool DetectCapital(string? input)
        {
            if (input.All(c => char.IsLower(c))) return true;

            if (input.All(c => char.IsUpper(c))) return true;

            char firstLetter = input.First();

            if (char.IsUpper(firstLetter) && input.Substring(1).All(c => char.IsLower(c))) return true;

            return false;
        }
    }
}
