using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public static class SharedSearchingTests
{
    
    public static void RandomArrayContainingTarget_FindsTarget(ISearcher searcher)
    {
        const int target = 1;
        const int expectedIndex = 4;
        int[] input = [5, 3, 8, 2, 1, 4];

        var index = searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayContainingTarget_FindsTarget(ISearcher searcher)
    {
        const int target = 6;
        const int expectedIndex = 2;
        int[] input = [3, 5, 6, 9, 11, 18, 20, 22, 24, 35];

        var index = searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayNotContainingTarget_NotFound(ISearcher searcher)
    {
        const int target = 34;
        const int expectedIndex = -1;
        int[] input = [3, 5, 6, 9, 11, 18, 20, 22, 24, 35];

        var index = searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    public static void RandomArrayContainingTargetWithRepeats_FindsTarget(ISearcher searcher)
    {
        const int target = 1;
        const int expectedIndex = 3;
        int[] input = [5, 3, 8, 1, 1, 4];

        var index = searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    public static void RandomArrayWithNegativeValuesContainingTarget_FindsTarget(ISearcher searcher)
    {
        const int target = -1;
        const int expectedIndex = 4;
        int[] input = [-5, 0, 8, 2, -1, 4];

        var index = searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    public static void RandomArrayNotContainingTarget_ReturnsNegativeOne(ISearcher searcher)
    {
        const int target = 125;
        const int expectedIndex = -1;
        int[] input = [5, 3, 8, 1, 1, 4];

        var index = searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }

    public static void EmptyArray_ReturnsNegativeOne(ISearcher searcher)
    {
        const int target = 125;
        const int expectedIndex = -1;
        int[] input = [];

        var index = searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayNotContainingTargetAtTheEnd_NotFound(ISearcher searcher)
    {
        const int target = 40;
        const int expectedIndex = -1;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayContainingTargetAtTheEnd_FindsTarget(ISearcher searcher)
    {
        const int target = 35;
        const int expectedIndex = 9;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayTargetZero_NotFound(ISearcher searcher)
    {
        const int target = 0;
        const int expectedIndex = -1;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayNegativeTarget_NotFound(ISearcher searcher)
    {
        const int target = -5;
        const int expectedIndex = -1;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayWithTwoItemsTargetAtSecondPosition_FindsTarget(ISearcher searcher)
    {
        const int target = 5;
        const int expectedIndex = 1;
        int[] input = [1, 5];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget(ISearcher searcher)
    {
        const int target = 1;
        const int expectedIndex = 0;
        int[] input = [1, 5];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound(ISearcher searcher)
    {
        const int target = 2;
        const int expectedIndex = -1;
        int[] input = [1, 5];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayWithOneItem_FindsTarget(ISearcher searcher)
    {
        const int target = 5;
        const int expectedIndex = 0;
        int[] input = [5];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayWithOneItemTargetBefore_NotFound(ISearcher searcher)
    {
        const int target = 2;
        const int expectedIndex = -1;
        int[] input = [5];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
    
    public static void SortedArrayWithOneItemTargetAfter_NotFound(ISearcher searcher)
    {
        const int target = 22;
        const int expectedIndex = -1;
        int[] input = [5];
    
        var index = searcher.Search(input, target);
    
        Assert.Equal(expectedIndex, index);
    }
}