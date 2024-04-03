namespace LengthOfLongestSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<char> chars = new HashSet<char>();
            int maxLength = 0;
            int start = 0;

            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (chars.Contains(currentChar))
                {
                    // Update start of the window to the position after the last occurrence of the character
                    while (input[start] != currentChar)
                    {
                        chars.Remove(input[start]);
                        start++;
                    }
                    start++;
                }
                else
                {
                    chars.Add(currentChar);
                    maxLength = Math.Max(maxLength, i - start + 1);
                }
            }

            Console.WriteLine(maxLength);
        }
    }
}
