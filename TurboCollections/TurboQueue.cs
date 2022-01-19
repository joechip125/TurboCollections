using System;

namespace TurboCollections
{
    public class TurboQueue<T>
    {
        public int Count { get; private set; }
        
        private T [] _items = Array.Empty<T>();
        
        
        void EnsureSize(int size)
        {
            if (_items.Length >= size)
            {
                return;
            }

            int newSize = Math.Max(size, _items.Length * 2);

            T[] newArray = new T[newSize];

            for (int i = 0; i < Count; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }
        
        public void Enqueue(T item)
        {
            EnsureSize(Count +1);
            
        }

        public T Peek()
        {
            return _items[0];
        }

        public T Dequeue()
        {
            T item = _items[0];
            
            _items[0] = default;

            for (int i = Count; i >= 0; i--)
            {
                _items[i] = _items[i - 1];
            }
            
            return item;
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                _items[i] = default;
            }
        }
    }
}