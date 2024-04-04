namespace ReverseInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = Reverse(input);

            Console.WriteLine(result);

        }
        static int Reverse(int x)
        {
            int reversed = 0;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                // Check for overflow before appending the next digit
                if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && digit > 7)) return 0;
                if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && digit < -8)) return 0;

                reversed = (reversed << 1) + (reversed << 3) + digit; // Equivalent to reversed * 10 + digit
            }

            return reversed;
        }
    }
}
