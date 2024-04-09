namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(100);
            bst.Insert(80);
            bst.Insert(120);
            bst.Insert(70);
            bst.Insert(90);
            bst.Insert(60);
            bst.Insert(75);
            bst.Insert(85);
            bst.Insert(95);
            bst.Insert(110);
            bst.Insert(130);




            bst.Delete(80);

            Console.WriteLine("In-order traversal: " + string.Join(", ", bst.InOrderTraversal())); // Output: 1, 4, 5, 6, 7, 9

            bst.PrintTree();


        }
    }
}
