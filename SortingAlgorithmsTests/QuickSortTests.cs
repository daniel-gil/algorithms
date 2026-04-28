using SortingAlgorithms;

namespace SortingAlgorithmsTests;

public class QuickSortTests
{
    private readonly ISorter _quickSort = new QuickSort();
    
    [Fact]
    public void QuickSort_NormalArray_SortsArrayCorrectly()
    {
        SharedComparisonSortTests.NormalArray_SortsArrayCorrectly(_quickSort);
    }
        
    // Test for QuickSort with a normal array (more scenarios)
    [Theory]
    [InlineData(new[] { 15, 6, 3, 1, 22, 10, 13 }, new[] { 1, 3, 6, 10, 13, 15, 22 } )]
    [InlineData(new[] { 35, 130, 80, 2, 15, 44, 67, 0, 256 }, new[] { 0, 2, 15, 35, 44, 67, 80, 130, 256 } )]
    public void QuickSort_NormalArrayV2_SortsArrayCorrectly(int[] input, int[] expected)
    {
        _quickSort.Sort(input);
        Assert.Equal(expected, input);
    }
    
    // Test for QuickSort with an array with duplicates
    [Fact]
    public void QuickSort_ArrayWithDuplicates_SortsArrayCorrectly()
    {
        SharedComparisonSortTests.ArrayWithDuplicates_SortsArrayCorrectly(_quickSort);
    }
    
    // Test with an empty array
    [Fact]
    public void QuickSort_EmptyArray_ShouldReturnEmptyArray()
    {
        SharedComparisonSortTests.EmptyArray_ShouldReturnEmptyArray(_quickSort);
    }
    
    // Test with an array containing only one element
    [Fact]
    public void QuickSort_OneElementArray_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.OneElementArray_ShouldReturnSameArray(_quickSort);
    }
    
    // Test with an array containing identical elements
    [Fact]
    public void QuickSort_IdenticalElements_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.IdenticalElements_ShouldReturnSameArray(_quickSort);
    }
    
    // Test with already sorted array
    [Fact]
    public void QuickSort_AlreadySortedArray_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.AlreadySortedArray_ShouldReturnSameArray(_quickSort);
    }
    
    // Test with reverse sorted array
    [Fact]
    public void QuickSort_ReverseSortedArray_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.ReverseSortedArray_ShouldSortCorrectly(_quickSort);
    }
    
    // Test with an array containing negative numbers
    [Fact]
    public void QuickSort_NegativeNumbers_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.NegativeNumbers_ShouldSortCorrectly(_quickSort);
    }
    
    // Test with large array (performance test)
    [Fact]
    public void QuickSort_LargeArray_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.LargeArray_ShouldSortCorrectly(_quickSort);
    }
    
    // Test with array containing zeros
    [Fact]
    public void QuickSort_ArrayWithZeros_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.ArrayWithZeros_ShouldSortCorrectly(_quickSort);
    }
}