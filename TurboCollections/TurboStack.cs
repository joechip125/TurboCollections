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
            Count++;
            
            if (Count < _items.Length)
            {
                _items[Count] = item;
            }
            
            else if (Count > _items.Length)
            {
                T[] array = new T[Count * 2];

                for (int i = 0; i < _items.Length; i++)
                {
                    array[i] = _items[i];
                }

                _items = array;
                _items[Count] = item;
                Count *= 2;
            }
        }

        public T Peek()
        {
            return _items[Count - 1];
        }

        public T Pop()
        {
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