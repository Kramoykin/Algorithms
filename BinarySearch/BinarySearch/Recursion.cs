using System;

namespace BinarySearch
{
    public class BinarySearchRecurcive
    {
        public static int? Search(int[] arr, int num)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low < high) 
            {
                (low, high) = RecourciveSearch(arr, low, high, num);
            }

            return low == high ? 0 : low;
        }

        protected static (int, int) RecourciveSearch(int[] arr, int leftIndex, int rightIndex, int num)
        {
            if (leftIndex == rightIndex)
            {
                return (leftIndex, leftIndex);
            }

            var median = (rightIndex + leftIndex) / 2;

            if (num > arr[median])
            {
                leftIndex = median + 1;
            }
            else
            {
                rightIndex = median;
            }

            return RecourciveSearch(arr, leftIndex, rightIndex, num);
        }
    }
}
