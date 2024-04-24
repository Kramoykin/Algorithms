namespace BinarySearch
{
    public class BinarySearchCycle
    {
        public static int? Search(int[] arr, int num)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low < high)
            {
                var median = (high + low) / 2;

                if (num > arr[median])
                {
                    low = median + 1;
                }
                else
                {
                    high = median;
                }
            }
            return arr[low] == num ? low : null;
        }
    }
}
