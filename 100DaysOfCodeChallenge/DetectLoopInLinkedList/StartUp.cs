namespace DetectLoopInLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            int[] input = Console.ReadLine()
                .Split("->", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            foreach (var num in input)
            {
                Node node = new Node(num);
                linkedList.AddNode(node);
            }

            Node loopStartNode = linkedList.FindLoopStart();

            if (loopStartNode != null)
            {
                Console.WriteLine($"Loop starts at Node {loopStartNode.Value}");
            }
            else
            {
                Console.WriteLine("No loop found");
            }
        }
    }
}
