namespace VowelCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> vowelsCount = new Dictionary<char, int>()
            {
                {'a',0 },
                {'e',0 },
                {'i',0 },
                {'o',0 },
                {'u',0 },
            };

            string input = Console.ReadLine();

            foreach (var letter in input)
            {
                if (vowelsCount.ContainsKey(letter))
                {
                    vowelsCount[letter]++;
                }
            }

            int vowelsSum = vowelsCount.Values.Sum();

            //A shorter way
            //int vowelsSum = input.Count(c => "aeiou".Contains(c));

            Console.WriteLine(vowelsSum);
        }
    }
}
