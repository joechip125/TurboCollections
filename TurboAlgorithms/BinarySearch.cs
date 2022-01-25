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
            bool found = false;
            int theGuess = primes.Count / 2;
            
            while (!found)
            {
                Console.WriteLine(min);
                if (numToFind == primes.Get(theGuess))
                {
                    found = true;
                }

                else
                {
                    if (numToFind > primes.Get(theGuess))
                    {
                        min = theGuess + 1;
                        int extra = (max - min) / 2;
                        theGuess =  min + extra;
                    }
                    else if(numToFind < primes.Get(theGuess))
                    {
                        max = theGuess - 1;
                        theGuess = max / 2;
                    }
                    else if (max < min || min > max)
                    {
                        found = true;
                        theGuess = -1;
                    }
                }
            }

            return theGuess;
        }

    }
}