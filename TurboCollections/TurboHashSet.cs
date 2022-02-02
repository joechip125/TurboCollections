using System;
using System.Collections;

namespace TurboCollections
{
    public class TurboHashSet<T>
    {
        private T[] _table;
    

        TurboHashSet()
        {
            _table = new T [GetPrimeNumber(32)];
        }

        public bool Insert(T value)
        {
            int hash = value.GetHashCode() % _table.Length;
            var some = _table[hash];

            if (_table[hash].Equals(value))
                return false;
            
            if (_table[hash] == null)
            {
                _table[hash] = value;
                return true;
            }
            
            if (_table[hash] != null)
            {
                
            }
            
            return false;
        }
        
        public bool Remove(T value)
        {

            return false;
        }
        
        public bool Exists(T value)
        {
            int code = value.GetHashCode() % _table.Length;

            if (_table[code] == null)
            {
                return false;
            }
            
            return false;
        }


        private void Resize()
        {
            
        }


        private int GetPrimeNumber(int suggestedNumber)
        {
            bool isPrime = false;
            while (!isPrime)
            {
                isPrime = IsPrime(suggestedNumber);

                if (!isPrime)
                    suggestedNumber++;
            }

            return suggestedNumber;
        }
        
        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i+=2)
                if (number % i == 0)
                    return false;

            return true;        
        }
    }
}