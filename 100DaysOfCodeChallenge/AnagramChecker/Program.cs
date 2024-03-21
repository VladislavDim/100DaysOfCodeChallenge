namespace AnagramChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();

            int firstSum = CalculateCharsSum(firstWord);
            int secondSum = CalculateCharsSum(secondWord);


            Console.WriteLine(firstSum == secondSum);
        }

        private static int CalculateCharsSum(string word)
        {
            int result = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 97 && word[i] <= 122)
                {
                    result += word[i];
                }
            }

            return result;
        }
    }
}
