using System;

namespace TurboCollections
{
    public class TurboList<T>
    {
        private T [] _items = Array.Empty<T>();
        private int _size = 0;
        
        TurboList()
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

            if (size < array.Length)
            {
                _size = size + 1;
                array[size] = item;
            }
            else
            {
                
            }
        }

        public T Get(int index)
        {
            if (_items.Length <= index)
            {
                return _items[index];
            }
            else
            {
                throw new System.Exception("index outside range of List");    
            }
        }

        void RemoveAt(int index)
        {
            
        }
    }
}