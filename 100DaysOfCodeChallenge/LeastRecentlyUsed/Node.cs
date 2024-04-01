namespace LeastRecentlyUsed
{
    public class Node
    {
        public Node(int key, int value)
        {
            this.Key = key;
            this.Value = value;
        }
        public int Key { get; private set; }
        public int Value { get; private set; }

    }
}
