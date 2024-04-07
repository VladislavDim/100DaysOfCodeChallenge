namespace FirstUniqueCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!charsCount.ContainsKey(input[i]))
                {
                    charsCount[input[i]] = i;
                }
                else if (charsCount.ContainsKey(input[i]))
                {
                    charsCount[input[i]] = -1;
                }
            }

            var result = charsCount.Values.Where(v => v >= 0);

            if (result.Any())
            {
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                Console.WriteLine(-1);
            }



        }
    }
}
