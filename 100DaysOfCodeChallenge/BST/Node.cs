namespace BST
{
    public class Node
    {
        public Node(int key)
        {
            this.Key = key;
            this.Left = null;
            this.Right = null;
        }
        public int Key { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

    }
}
