using System;

namespace TurboCollections
{
    public class TurboStack<T>
    {
        private T [] _items = Array.Empty<T>();
        private int _size = 0;

        public TurboStack()
        {
            _items = new T[8];
            _size = 8;
        }

        public int Count()
        {
            return _size;
        }

        public void Push(T item)
        {
            _size++;
            
            if (_size < _items.Length)
            {
                _items[_size] = item;
            }
            
            else if (_size > _items.Length)
            {
                T[] array = new T[_size * 2];

                for (int i = 0; i < _items.Length; i++)
                {
                    array[i] = _items[i];
                }

                _items = array;
                _items[_size] = item;
                _size *= 2;
            }
        }

        public T Peek()
        {
            return _items[_size - 1];
        }

        public T Pop()
        {
            T item = _items[_size -1];
            _items[_size -1] = default!;
            _size--;

            return item;
        }

        public void Clear()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                _items[i] = default!;
            }
            _size = 0;
        }
    }
}