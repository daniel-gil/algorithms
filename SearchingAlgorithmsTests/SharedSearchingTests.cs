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
}