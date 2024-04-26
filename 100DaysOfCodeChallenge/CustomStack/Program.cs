namespace CustomStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop()); //Should print 3
            Console.WriteLine(stack.Pop()); //Should print 2
        }
    }
}
