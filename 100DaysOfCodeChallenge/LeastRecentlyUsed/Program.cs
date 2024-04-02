namespace LeastRecentlyUsed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            LRUCache cache = new LRUCache(capacity);

            cache.Put(1, 1);
            cache.Put(2, 2);
            Console.WriteLine(cache.Get(1));// returns 1
            cache.Put(3, 3); // evicts key 2
            Console.WriteLine(cache.Get(2));    // returns -1 (not found)
            cache.Put(4, 4); // evicts key 1
            Console.WriteLine(cache.Get(1));    // returns -1 (not found)
            Console.WriteLine(cache.Get(3));    // returns 3
            Console.WriteLine(cache.Get(4));
        }
    }
}
