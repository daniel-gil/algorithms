using SortingAlgorithms;

namespace SortingAlgorithmsTests;

public class SelectionSortTests
{
    private readonly ISorter _selectionSort = new SelectionSort();
    
    // Test for SelectionSort with a normal array
    [Fact]
    public void SelectionSort_SortsArrayCorrectly()
    {
        SharedComparisonSortTests.NormalArray_SortsArrayCorrectly(_selectionSort);
    }
    
    // Test with an empty array
    [Fact]
    public void SelectionSort_EmptyArray_ShouldReturnEmptyArray()
    {
        SharedComparisonSortTests.EmptyArray_ShouldReturnEmptyArray(_selectionSort);
    }

    // Test with an array containing only one element
    [Fact]
    public void SelectionSort_OneElementArray_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.OneElementArray_ShouldReturnSameArray(_selectionSort);
    }
    
    // Test with an array containing identical elements
    [Fact]
    public void SelectionSort_IdenticalElements_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.IdenticalElements_ShouldReturnSameArray(_selectionSort);
    }

    // Test with already sorted array
    [Fact]
    public void SelectionSort_AlreadySortedArray_ShouldReturnSameArray()
    {
        SharedComparisonSortTests.AlreadySortedArray_ShouldReturnSameArray(_selectionSort);
    }

    // Test with reverse sorted array
    [Fact]
    public void SelectionSort_ReverseSortedArray_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.ReverseSortedArray_ShouldSortCorrectly(_selectionSort);
    }

    // Test with an array containing negative numbers
    [Fact]
    public void SelectionSort_NegativeNumbers_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.NegativeNumbers_ShouldSortCorrectly(_selectionSort);
    }

    // Test with large array (performance test)
    [Fact]
    public void SelectionSort_LargeArray_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.LargeArray_ShouldSortCorrectly(_selectionSort);
    }

    // Test with array containing zeros
    [Fact]
    public void SelectionSort_ArrayWithZeros_ShouldSortCorrectly()
    {
        SharedComparisonSortTests.ArrayWithZeros_ShouldSortCorrectly(_selectionSort);
    }
}