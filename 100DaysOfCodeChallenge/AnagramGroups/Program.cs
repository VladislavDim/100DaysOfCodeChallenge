namespace AnagramGroups
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                //int key = input[i].Sum(c => (int)c);
                //string key = CalculateKey(input[i]);
                string key = new string(input[i].OrderBy(c => c).ToArray());

                if (!anagramGroups.ContainsKey(key))
                {
                    anagramGroups[key] = new List<string>();
                }
                anagramGroups[key].Add(input[i]);
            }

            foreach (var group in anagramGroups.Values)
            {
                Console.WriteLine(string.Join(", ", group));

            }
        }
        static string CalculateKey(string word)
        {
            var charCounts = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (!charCounts.ContainsKey(c))
                {
                    charCounts[c] = 0;
                }
                charCounts[c]++;
            }

            return string.Join("", charCounts.OrderBy(pair => pair.Key).Select(pair => $"{pair.Key}{pair.Value}"));
        }
    }
}
