namespace LongestPalindromicSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) Console.WriteLine("");

            int start = 0, end = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int len1 = ExpandAroundCenter(input, i, i);
                int len2 = ExpandAroundCenter(input, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            string result = input.Substring(start, end - start + 1);

            Console.WriteLine(result);
        }
        private static int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}
