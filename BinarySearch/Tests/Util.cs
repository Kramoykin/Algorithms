namespace BinarySearch.Tests;


public static class ArrayHandler
{
    public static int[] GenerateSortedArray(int size)
    {
        // Initialize the random number generator
        Random random = new Random(42);

        // Create an array to hold the random integers
        int[] array = new int[size];

        // Populate the array with random integers
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 100000); // Random integers between 0 and 100,000
        }

        // Sort the array in ascending order
        Array.Sort(array);

        // Return the sorted array
        return array;
    }

    // Returns a random element from the given array
    public static (int, T) GetRandomElement<T>(T[] array)
    {
        // Check if the array is empty
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.", nameof(array));
        }

        // Initialize the random number generator
        Random random = new Random(42);

        // Generate a random index
        int index = random.Next(array.Length);

        // Return the element at the randomly generated index
        return (index, array[index]);
    }
}