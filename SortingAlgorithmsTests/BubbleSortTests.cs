using SortingAlgorithms;

namespace SortingAlgorithmsTests;

public class BubbleSortTests
{
    private readonly ISorter _bubbleSort = new BubbleSort();
    
    // Test for BubbleSort with a normal array
    [Fact]
    public void BubbleSort_SortsArrayCorrectly()
    {
        int[] input = { 5, 3, 8, 2, 1, 4 };
        int[] expected = { 1, 2, 3, 4, 5, 8 };

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }
    
    // Test with an empty array
    [Fact]
    public void BubbleSort_EmptyArray_ShouldReturnEmptyArray()
    {
        int[] input = [];
        int[] expected = [];

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }

    // Test with an array containing only one element
    [Fact]
    public void BubbleSort_OneElementArray_ShouldReturnSameArray()
    {
        int[] input = [ 5 ];
        int[] expected = [ 5 ];

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }
    
    // Test with an array containing identical elements
    [Fact]
    public void BubbleSort_IdenticalElements_ShouldReturnSameArray()
    {
        int[] input = { 5, 5, 5, 5, 5 };
        int[] expected = { 5, 5, 5, 5, 5 };

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }

    // Test with already sorted array
    [Fact]
    public void BubbleSort_AlreadySortedArray_ShouldReturnSameArray()
    {
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expected = { 1, 2, 3, 4, 5 };

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }

    // Test with reverse sorted array
    [Fact]
    public void BubbleSort_ReverseSortedArray_ShouldSortCorrectly()
    {
        int[] input = { 5, 4, 3, 2, 1 };
        int[] expected = { 1, 2, 3, 4, 5 };

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }

    // Test with an array containing negative numbers
    [Fact]
    public void BubbleSort_NegativeNumbers_ShouldSortCorrectly()
    {
        int[] input = { -5, 3, -1, 7, 0, 2 };
        int[] expected = { -5, -1, 0, 2, 3, 7 };

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }

    // Test with large array (performance test)
    [Fact]
    public void BubbleSort_LargeArray_ShouldSortCorrectly()
    {
        int[] input = new int[1000];
        for (int i = 0; i < 1000; i++) input[i] = 1000 - i;  // Reverse order
        int[] expected = new int[1000];
        for (int i = 0; i < 1000; i++) expected[i] = i + 1;  // Sorted order

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }

    // Test with array containing zeros
    [Fact]
    public void BubbleSort_ArrayWithZeros_ShouldSortCorrectly()
    {
        int[] input = { 0, 3, 0, 1, 2 };
        int[] expected = { 0, 0, 1, 2, 3 };

        _bubbleSort.Sort(input);

        Assert.Equal(expected, input);
    }
}