

namespace UniqueLongestSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string crnSubstr = GetUniqueSubstring(input, i);

                if (crnSubstr.Length > result.Length)
                {
                    result = crnSubstr;
                }
                if (crnSubstr.Length >= input.Length / 2)
                {
                    result = crnSubstr;
                    break;
                }
            }

            Console.WriteLine(result);
        }

        private static string GetUniqueSubstring(string input, int index)
        {
            string result = string.Empty;

            for (int i = index; i < input.Length; i++)
            {
                if (i == index)
                {
                    result += input[i];
                }
                else if (result[result.Length - 1] != input[i])
                {
                    result += input[i];
                }
                else
                {
                    break;
                }

            }

            return result;
        }
    }
}
