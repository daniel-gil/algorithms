using SortingAlgorithms;

namespace SortingAlgorithmsTests;

public static class SharedComparisonSortTests
{
    // normal array
    public static void NormalArray_SortsArrayCorrectly(ISorter sorter)
    {
        int[] input = { 5, 3, 8, 2, 1, 4 };
        int[] expected = { 1, 2, 3, 4, 5, 8 };

        sorter.Sort(input);

        Assert.Equal(expected, input);
    }
    
    // empty array
    public static void EmptyArray_ShouldReturnEmptyArray(ISorter sorter)
    {
        int[] input = [];
        int[] expected = [];
    
        sorter.Sort(input);
    
        Assert.Equal(expected, input);
    }
    
    // an array containing only one element
    public static void OneElementArray_ShouldReturnSameArray(ISorter sorter)
    {
        int[] input = [ 5 ];
        int[] expected = [ 5 ];
    
        sorter.Sort(input);
    
        Assert.Equal(expected, input);
    }
    
    // an array containing identical elements
    public static void IdenticalElements_ShouldReturnSameArray(ISorter sorter)
    {
        int[] input = { 5, 5, 5, 5, 5 };
        int[] expected = { 5, 5, 5, 5, 5 };
    
        sorter.Sort(input);
    
        Assert.Equal(expected, input);
    }
    
    // Test with already sorted array
    public static void AlreadySortedArray_ShouldReturnSameArray(ISorter sorter)
    {
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expected = { 1, 2, 3, 4, 5 };
    
        sorter.Sort(input);
    
        Assert.Equal(expected, input);
    }
    
    // Test with reverse sorted array
    public static void ReverseSortedArray_ShouldSortCorrectly(ISorter sorter)
    {
        int[] input = { 5, 4, 3, 2, 1 };
        int[] expected = { 1, 2, 3, 4, 5 };
    
        sorter.Sort(input);
    
        Assert.Equal(expected, input);
    }
    
    // Test with an array containing negative numbers
    public static void NegativeNumbers_ShouldSortCorrectly(ISorter sorter)
    {
        int[] input = { -5, 3, -1, 7, 0, 2 };
        int[] expected = { -5, -1, 0, 2, 3, 7 };
    
        sorter.Sort(input);
    
        Assert.Equal(expected, input);
    }
    
    // Test with large array (performance test)
    public static void LargeArray_ShouldSortCorrectly(ISorter sorter)
    {
        int[] input = new int[1000];
        for (int i = 0; i < 1000; i++) input[i] = 1000 - i;  // Reverse order
        
        int[] expected = new int[1000];
        for (int i = 0; i < 1000; i++) expected[i] = i + 1;  // Sorted order
    
        sorter.Sort(input);
    
        Assert.Equal(expected, input);
    }
    
    // Test with array containing zeros
    public static void ArrayWithZeros_ShouldSortCorrectly(ISorter sorter)
    {
        int[] input = { 0, 3, 0, 1, 2 };
        int[] expected = { 0, 0, 1, 2, 3 };
    
        sorter.Sort(input);
    
        Assert.Equal(expected, input);
    }
}