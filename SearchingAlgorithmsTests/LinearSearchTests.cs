using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class LinearSearchTests
{
    private readonly ISearcher _searcher = new LinearSearch();
    
    [Fact]
    public void LinearSearch_ArrayContainingTarget_FindsTarget()
    {
        const int target = 1;
        const int expectedIndex = 4;
        int[] input = [5, 3, 8, 2, 1, 4];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void LinearSearch_ArrayContainingTargetWithRepeats_FindsTarget()
    {
        const int target = 1;
        const int expectedIndex = 3;
        int[] input = [5, 3, 8, 1, 1, 4];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void LinearSearch_ArrayWithNegativeValuesContainingTarget_FindsTarget()
    {
        const int target = -1;
        const int expectedIndex = 4;
        int[] input = [-5, 0, 8, 2, -1, 4];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void LinearSearch_ArrayNotContainingTarget_ReturnsNegativeOne()
    {
        const int target = 125;
        const int expectedIndex = -1;
        int[] input = [5, 3, 8, 1, 1, 4];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void LinearSearch_EmptyArray_ReturnsNegativeOne()
    {
        const int target = 125;
        const int expectedIndex = -1;
        int[] input = [];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
}