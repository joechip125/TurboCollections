using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public class TurboList<T>
    {
        private T [] _items = Array.Empty<T>();
        private int _size = 0;
        
        public TurboList()
        {

        }

        public int Count()
        {
            return _size;
        }

        public void Add(T item)
        {

            T[] array = _items;
            int size = _size;
            if (_size < _items.Length)
            {
                _size = size + 1;
                array[size] = item;
            }
            
            else
            {
                T[] newArray = new T[size * 2];

                for (int i = 0; i < _size; i++)
                {
                    newArray[i] = _items[i];
                }

                _items = newArray;
                newArray[size] = item;
            }
        }

        public T Get(int index)
        {
            if (_items.Length < index)
            {
                return _items[index];
            }
            
            throw new System.Exception("index outside range of List");
        }

        public void Clear()
        {
            _items = Array.Empty<T>();
            _size = 0;
        }
        
        void RemoveAt(int index)
        {
            
        }

        bool Contains(T item)
        {
            var temp = item;
            foreach (var el in _items)
            {
                
            }

            return false;
        }
    }
}