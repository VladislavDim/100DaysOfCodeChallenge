namespace CustomQueue
{
    public class MyCustomQueue<T> : IMyCustomQueue<T>
    {
        private readonly List<T> _items;
        public MyCustomQueue()
        {
            this._items = new List<T>();
        }

        public int Count => this._items.Count;

        public T Dequeue()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T result = _items.First();
            _items.Remove(result);

            return result;
        }

        public void Enqueue(T item)
        {
            _items.Add(item);
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }
    }
}
