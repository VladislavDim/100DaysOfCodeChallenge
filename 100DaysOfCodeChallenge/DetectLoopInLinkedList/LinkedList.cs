
namespace DetectLoopInLinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private Dictionary<int, Node> valueNodes = new Dictionary<int, Node>();
        public void AddNode(Node node)
        {
            if (!valueNodes.ContainsKey(node.Value))
            {
                valueNodes[node.Value] = node;

                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    tail.Next = node;
                    tail = node;
                }
            }
            else
            {
               tail.Next = valueNodes[node.Value];
            }
        }

        public Node FindLoopStart()
        {
            Node slow = head;
            Node fast = head;

            while (slow != null && fast != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    slow = head;

                    while (slow != fast)
                    {
                        slow = slow.Next;
                        fast = fast.Next;
                    }
                    return slow;
                }
            }
            return null;
        }

    }
}
