using SortingAlgorithms;

namespace SortingAlgorithmsTests;

public class BubbleSortTests
{
    private readonly ISorter _bubbleSort = new BubbleSort();
    
    // Test for BubbleSort with a normal array
    [Fact]
    public void BubbleSort_SortsArrayCorrectly()
    {
        SharedComparisonSortTests.NormalArray_SortsArrayCorrectly(_bubbleSort);
    }
    
    // Test with an empty array
    [Fact]
    public void BubbleSort_EmptyArray_ShouldReturnEmptyArray()
    {
        SharedComparisonSortTests.EmptyArray_ShouldReturnEmptyArray(_bubbleSort);
    }

    // Test with an array containing only one element
    [Fact]
    public void BubbleSort_OneElementArray_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.OneElementArray_ShouldReturnSameArray(_bubbleSort);
    }
    
    // Test with an array containing identical elements
    [Fact]
    public void BubbleSort_IdenticalElements_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.IdenticalElements_ShouldReturnSameArray(_bubbleSort);
    }

    // Test with already sorted array
    [Fact]
    public void BubbleSort_AlreadySortedArray_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.AlreadySortedArray_ShouldReturnSameArray(_bubbleSort);
    }

    // Test with reverse sorted array
    [Fact]
    public void BubbleSort_ReverseSortedArray_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.ReverseSortedArray_ShouldSortCorrectly(_bubbleSort);
    }

    // Test with an array containing negative numbers
    [Fact]
    public void BubbleSort_NegativeNumbers_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.NegativeNumbers_ShouldSortCorrectly(_bubbleSort);
    }

    // Test with large array (performance test)
    [Fact]
    public void BubbleSort_LargeArray_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.LargeArray_ShouldSortCorrectly(_bubbleSort);
    }

    // Test with array containing zeros
    [Fact]
    public void BubbleSort_ArrayWithZeros_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.ArrayWithZeros_ShouldSortCorrectly(_bubbleSort);
    }
}