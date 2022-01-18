using System;

namespace TurboCollections
{
    public class TurboStack<T>
    {
        private T [] _items = Array.Empty<T>();
        private int _size = 0;
        
        public int Count()
        {
            return _size;
        }

        public void Push(T item)
        {
        //    T[] array = _items;
            
            if (_size == 0)
            {
                T[] array = new T[1];
            }
        }

        public T Peek()
        {
            return _items[_size];
        }

        public T Pop()
        {
            int size = _size - 1;
            T[] array = _items;
            
            T item = _items[_size];
            
            _items[_size] = default!;
            
            return item;
        }

        public void Clear()
        {
            _items = Array.Empty<T>();
            _size = 0;
        }
    }
}