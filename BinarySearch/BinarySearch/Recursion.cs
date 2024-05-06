namespace BinarySearch
{
    public class BinarySearchRecurcive
    {
        public static int? Search(int[] arr, int num)
        {
            int low = 0;
            int high = arr.Length - 1;

            return RecourciveSearch(arr, low, high, num);
        }

        protected static int? RecourciveSearch(int[] arr, int leftIndex, int rightIndex, int num)
        {
            if (leftIndex == rightIndex)
            {
                if (arr[leftIndex] == num)
                {
                    return leftIndex;
                }

                return null;
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
