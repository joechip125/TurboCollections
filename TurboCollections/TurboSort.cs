using System.Dynamic;

namespace TurboCollections
{
    public static class TurboSort
    {
        public static void BubbleSort(TurboList<int> list)
        {
            bool swapped = false;
            int endIndex = list.Count - 1;
            do
            {
                for (int i = 0; i < list.Count  - 1; i++)
                {
                    if (list.Get(i) > list.Get(i + 1))
                    {
                        int b = list.Get(i + 1);
                        list.Set(i + 1, list.Get(i));
                           
                    }
                }
                swapped = false;
            } while (swapped);
        }

        public static void QuickSort(TurboList<int> list, int left = 0, int? right = null)
        {
            var _right = right ?? list.Count - 1;

            if (_right - left <= 0)
                return;

            int pivot = list.Get(_right);
            int partition = Partition(list, left, _right, pivot);
            QuickSort(list, left, partition - 1);
            QuickSort(list, partition+ 1, _right);
        }
        
        private static int Partition(TurboList<int> list, int left, int right, int pivot)
        {
            int leftPointer = left;
            int rightPointer = right;

            while (true)
            {
                while (list.Get(leftPointer++) < pivot) ;
                while (rightPointer > 0 && list.Get(rightPointer--) > 0) ;

                if (rightPointer >= leftPointer)
                    break;

                int b = list.Get(rightPointer);
                
                list.Set(rightPointer, list.Get(leftPointer));
                list.Set(leftPointer, b);

            }

            return 0;
        }
    }

 
}