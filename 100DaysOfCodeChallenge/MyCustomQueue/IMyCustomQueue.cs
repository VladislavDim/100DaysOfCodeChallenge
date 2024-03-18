namespace CustomQueue
{
    public interface IMyCustomQueue<T>
    {
        int Count { get; }
        T Dequeue();
        void Enqueue(T item);
        bool IsEmpty();
    }
}
