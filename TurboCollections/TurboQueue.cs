using System;

namespace TurboCollections
{
    public class TurboQueue<T>
    {
        public int Count { get; private set; }
        
        private T [] _items = Array.Empty<T>();
        
        public int end = 0;    // write index
        public int start = 0;  // read index
        
        
        
        public void Enqueue(T item)
        {
            CollectionUtil.EnsureSize(ref _items, Count + 1);

            if (end > Count)
            {
                end = 0;
            }

            Count++;
            _items[end++] = item;
        }

        public T Peek()
        {
            return _items[start];
        }

        public T Dequeue()
        {
            if (start > Count)
            {
                start = 0;
            }
            T item = _items[start];
            
            
            _items[start++] = default;
            
            return item;
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                _items[i] = default;
            }

            Count = 0;
            start = 0;
            end = 0;
        }
    }
}