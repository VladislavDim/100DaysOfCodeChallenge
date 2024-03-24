namespace ValidParentheses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'(',1 },
                {')',-1 },
                {'{',2 },
                {'}',-2 },
                {'[',3 },
                {']',-3 }
            };

            string input = Console.ReadLine();

            Stack<int> bracketsValues = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int value = map[input[i]];
          
                if (value > 0)
                {
                    bracketsValues.Push(value);
                }
                else if (bracketsValues.Count == 0 || bracketsValues.Pop() != -value)
                {
                    Console.WriteLine(false);
                    return;
                }
            }

            Console.WriteLine(bracketsValues.Count == 0);


        }
    }
}
