namespace LeastRecentlyUsed
{
    public class CustomLinkedList
    {
        private Node head;
        private Node tail;

        private int capacity;
        private int count;
        public CustomLinkedList(int capacity)
        {
            this.capacity = capacity;
            head = new Node(-1, -1); // Dummy head node
            tail = new Node(-1, -1); // Dummy tail node
            head.Next = tail;
            tail.Prev = head;
            count = 0;
        }

        public int Capacity => this.capacity;
        public int Count => this.count;
        public void AddToFront(Node node)
        {
            node.Next = head.Next;
            node.Prev = head;
            head.Next.Prev = node;
            head.Next = node;
            count++;
        }

        public void Remove(Node node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            count--;
        }

        public Node RemoveLast()
        {
            Node lastNode = tail.Prev;
            Remove(lastNode);
            return lastNode;
        }


    }
}
