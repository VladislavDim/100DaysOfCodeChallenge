using System.Dynamic;

namespace LeastRecentlyUsed
{
    public class LRUCache
    {
        private CustomLinkedList linkedList;
        private Dictionary<int, Node> map;

        public LRUCache(int capacity)
        {
            linkedList = new CustomLinkedList(capacity);
            map = new Dictionary<int, Node>();
        }

        public int Get(int key)
        {
            if (!map.ContainsKey(key))
                return -1;

            Node node = map[key];
            linkedList.Remove(node);
            linkedList.AddToFront(node);
            return node.Value;
        }

        public void Put(int key, int value)
        {
            if (map.ContainsKey(key))
            {
                Node node = map[key];
                linkedList.Remove(node);
                node.Value = value;
                linkedList.AddToFront(node);
            }
            else
            {
                if (linkedList.Count >= linkedList.Capacity)
                {
                    Node lastNode = linkedList.RemoveLast();
                    map.Remove(lastNode.Key);
                }

                Node newNode = new Node(key, value);
                linkedList.AddToFront(newNode);
                map[key] = newNode;
            }
        }
    }
}
