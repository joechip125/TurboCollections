using System;

namespace TurboCollections
{
    public static class CollectionUtil
    {
        public static void EnsureSize<T>(ref T[] items, int size)
        {
            if (items.Length >= size)
            {
                return;
            }

            int newSize = Math.Max(size, items.Length * 2);

            T[] newArray = new T[newSize];

            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }
    }
}