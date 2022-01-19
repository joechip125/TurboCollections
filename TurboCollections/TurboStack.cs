using System;

namespace TurboCollections
{
    public class TurboStack<T>
    {
        private T [] _items;
        public int Count { get; private set; }

        public TurboStack()
        {
            _items = new T[8];
            Count = 8;
        }
        
        public void Push(T item)
        {
            CollectionUtil.EnsureSize(ref _items, Count + 1);
            _items[Count++] = item;
        }

        public T Peek()
        {
            return _items[Count - 1];
        }

        public T Pop()
        {
            //    return _items[--Count];
            T item = _items[Count -1];
            _items[Count -1] = default!;
            Count--;

            return item;
        }

        public void Clear()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                _items[i] = default!;
            }
            Count = 0;
        }
    }
}