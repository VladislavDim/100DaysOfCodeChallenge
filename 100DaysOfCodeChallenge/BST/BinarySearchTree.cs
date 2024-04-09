
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
        public void Delete(int key)
        {
            root = DeleteRec(root, key);
        }
        public List<int> InOrderTraversal()
        {
            List<int> result = new List<int>();
            InOrderTraversalRec(root, result);
            return result;
        }
        public void PrintTree()
        {
            PrintTreeRec(this.root, 0);
        }
        private Node DeleteRec(Node root, int key)
        {
            if (root == null)
            {
                return null;
            }

            if (key < root.Key)
            {
                root.Left = DeleteRec(root.Left, key);
            }
            else if (key > root.Key)
            {
                root.Right = DeleteRec(root.Right, key);
            }
            else
            {
                // Case 1: Node with only one child or no child
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                // Case 2: Node with two children
                // Get the inorder successor (smallest in the right subtree)
                root.Key = MinValue(root.Right);

                // Delete the inorder successor
                root.Right = DeleteRec(root.Right, root.Key);
            }

            return root;
        }
        private int MinValue(Node root)
        {
            int minv = root.Key;
            while (root.Left != null)
            {
                minv = root.Left.Key;
                root = root.Left;
            }
            return minv;
        }
        private void InOrderTraversalRec(Node root, List<int> result)
        {
            if (root != null)
            {
                InOrderTraversalRec(root.Left, result);
                result.Add(root.Key);
                InOrderTraversalRec(root.Right, result);
            }
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
        static void PrintTreeRec(Node root, int space)
        {
            // Base case
            if (root == null)
                return;

            // Increase distance between levels
            space += 5;

            // Process right child first
            PrintTreeRec(root.Right, space);

            // Print current node after space
            // count
            Console.Write("\n");
            for (int i = 5; i < space; i++)
                Console.Write(" ");
            Console.Write(root.Key + "\n");

            // Process left child
            PrintTreeRec(root.Left, space);
        }
    }
}
