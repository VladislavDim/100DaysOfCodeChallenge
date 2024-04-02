namespace LeastRecentlyUsed
{
    public class Node
    {
        public Node(int key, int value)
        {
            this.Key = key;
            this.Value = value;
        }
        public int Key { get; set; }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
    }
}
