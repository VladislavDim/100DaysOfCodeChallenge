
namespace BST
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(int key)
        {
            root = InsertRec(root, key);
        }
        public bool Search(int key)
        {
            return SearchRec(root, key);
        }

        private bool SearchRec(Node root, int key)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Key == key)
            {
                return true;
            }

            if (key < root.Key)
            {
                return SearchRec(root.Left, key);
            }
            else
            {
                return SearchRec(root.Right, key);
            }
        }

        private Node InsertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }
            if (key < root.Key)
            {
                root.Left = InsertRec(root.Left, key);
            }
            else if (key > root.Key)
            {
                root.Right = InsertRec(root.Right, key);
            }

            return root;

        }
    }
}
