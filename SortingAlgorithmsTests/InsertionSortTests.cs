using SortingAlgorithms;

namespace SortingAlgorithmsTests;

public class InsertionSortTests
{
    private readonly ISorter _insertionSort = new InsertionSort();
    
    // Test for InsertionSort with a normal array
    [Fact]
    public void InsertionSort_SortsArrayCorrectly()
    {
        SharedComparisonSortTests.NormalArray_SortsArrayCorrectly(_insertionSort);
    }
    
    // Test with an empty array
    [Fact]
    public void InsertionSort_EmptyArray_ShouldReturnEmptyArray()
    {
        SharedComparisonSortTests.EmptyArray_ShouldReturnEmptyArray(_insertionSort);
    }

    // Test with an array containing only one element
    [Fact]
    public void InsertionSort_OneElementArray_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.OneElementArray_ShouldReturnSameArray(_insertionSort);
    }
    
    // Test with an array containing identical elements
    [Fact]
    public void InsertionSort_IdenticalElements_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.IdenticalElements_ShouldReturnSameArray(_insertionSort);
    }

    // Test with already sorted array
    [Fact]
    public void InsertionSort_AlreadySortedArray_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.AlreadySortedArray_ShouldReturnSameArray(_insertionSort);
    }

    // Test with reverse sorted array
    [Fact]
    public void InsertionSort_ReverseSortedArray_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.ReverseSortedArray_ShouldSortCorrectly(_insertionSort);
    }

    // Test with an array containing negative numbers
    [Fact]
    public void InsertionSort_NegativeNumbers_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.NegativeNumbers_ShouldSortCorrectly(_insertionSort);
    }

    // Test with large array (performance test)
    [Fact]
    public void InsertionSort_LargeArray_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.LargeArray_ShouldSortCorrectly(_insertionSort);
    }

    // Test with array containing zeros
    [Fact]
    public void InsertionSort_ArrayWithZeros_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.ArrayWithZeros_ShouldSortCorrectly(_insertionSort);
    }
}