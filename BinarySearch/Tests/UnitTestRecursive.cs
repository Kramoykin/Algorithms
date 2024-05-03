using static BinarySearch.BinarySearchRecurcive;
using static BinarySearch.Tests.ArrayHandler;


namespace BinarySearch.Tests;

public class BinarySearchTestsRecurcive
{
    [Fact]
    public void TestElementFound()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 4;
        int expectedIndex = 3; // »ндекс элемента '4' в массиве

        var result = Search(array, target);

        Assert.Equal(expectedIndex, result);
    }

    [Fact]
    public void TestElementNotFound()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 11; // Ёлемента нет в массиве

        var result = Search(array, target);

        Assert.Null(result);
    }

    [Fact]
    public void TestRepeatingElement()
    {
        int[] array = { 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10 };
        int target = 5;

        var result = Search(array, target);

        Assert.Equal(target, array[(int)result!]);
    }

    [Theory]
    [InlineData(10)]
    [InlineData(100)]
    [InlineData(1000)]
    [InlineData(10000)]
    [InlineData(100000)]
    [InlineData(1000000)]
    public void TestVariousSizes(int size)
    {
        int[] array = GenerateSortedArray(size);
        var (expectedIndex, target) = GetRandomElement(array);

        var result = (int)Search(array, target)!;

        Assert.Equal(array[expectedIndex], array[result]);
    }

    [Fact]
    public void TestElementNotFoundHugeArray()
    {
        var random = new Random(42);
        int[] array = GenerateSortedArray(100000);
        var hashset = new HashSet<int>(array);
        int target = 40;
        while (hashset.Contains(target))
        {
            target = random.Next();
        }

        var result = Search(array, target);

        Assert.Null(result);
    }
}