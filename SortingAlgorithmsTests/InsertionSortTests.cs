using SortingAlgorithms;

namespace SortingAlgorithmsTests;

public class InsertionSortTests
{
    private readonly ISorter _insertionSort = new InsertionSort();
    
    // Test for InsertionSort with a normal array
    [Fact]
    public void InsertionSort_NormalArray_SortsArrayCorrectly()
    {
        SharedComparisonSortTests.NormalArray_SortsArrayCorrectly(_insertionSort);
    }
    
    // Test for InsertionSort with a normal array (more scenarios)
    [Theory]
    [InlineData(new[] { 8, 2, 4, 1, 3 }, new[] { 1, 2, 3, 4, 8 } )]
    [InlineData(new[] { 15, 6, 3, 1, 22, 10, 13 }, new[] { 1, 3, 6, 10, 13, 15, 22 } )]
    [InlineData(new[] { 35, 130, 80, 2, 15, 44, 67, 0, 256 }, new[] { 0, 2, 15, 35, 44, 67, 80, 130, 256 } )]
    public void InsertionSort_NormalArrayV2_SortsArrayCorrectly(int[] input, int[] expected)
    {
        _insertionSort.Sort(input);
        Assert.Equal(expected, input);
    }

    // Test for InsertionSort_ with an array with duplicates
    [Fact]
    public void InsertionSort_ArrayWithDuplicates_SortsArrayCorrectly()
    {
        SharedComparisonSortTests.ArrayWithDuplicates_SortsArrayCorrectly(_insertionSort);
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