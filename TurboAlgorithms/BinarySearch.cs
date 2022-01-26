using System;
using TurboCollections;

namespace TurboAlgorithms
{
    public class BinarySearch
    {
        public static TurboList<int> primes = new TurboList<int>() 
            {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 123};



        public static int BinarySearchSimple(int numToFind)
        {
            int max = primes.Count - 1;
            int min = 0;
            int mid = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;
                Console.WriteLine($"Current min {min}");
                Console.WriteLine($"Current max {max}");
                Console.WriteLine($"Current guess {mid}");

                if (numToFind == primes.Get(mid)) 
                {
                    return ++mid;
                } 
                
                else if (primes.Get(mid) < numToFind ) 
                {
                    min = mid + 1;
                }
                
                else 
                {
                    max = mid - 1;
                }
            }

            return mid;
        }

    }
}