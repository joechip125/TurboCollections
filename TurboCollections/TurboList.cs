using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TurboCollections
{
    public class TurboList<T> : IEnumerable<T>
    {
        private T [] _items = Array.Empty<T>();
        public int Count { get; private set; }
        
        public TurboList()
        {

        }

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

        public void Add(T item)
        {
            EnsureSize(Count + 1);
            _items[Count++] = item;
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
            for (int i = 0; i < Count; i++)
            {
                _items[i] = default;
            }
            
            Count = 0;
        }
        
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            
            Count--;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(_items[i]))
                    return i;
            }

            return -1;
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var el in items)
            {
                Add(el);    
            }
        }
        
        
        
        
        public bool Contains(T item)
        {
        //    return _items.Any(x => x.Equals(item));
        
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(_items[i]))
                {
                    return true;
                }
            }
            
            return false;
        }

        public void Set(int index, T item)
        {
            if (index >= Count)
            {
                EnsureSize(index + 1);
                Count = index + 1;
            }
            _items[index] = item;
        }


        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        public struct Enumerator : IEnumerator<T>
        {
            private readonly T[] items;
            private readonly int count;
            private int index;
            
            public bool MoveNext()
            {
                if (index >= count)
                {
                    return false;
                }

                return  ++index < count;
                
            }

            public void Reset()
            {
                index = -1;
            }

            public T Current { get; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}