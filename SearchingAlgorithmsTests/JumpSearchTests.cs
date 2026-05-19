using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class JumpSearchTests
{
    private readonly ISearcher _searcher = new JumpSearch();
    
    [Fact]
    public void JumpSearch_SortedArrayNotContainingTarget_NotFound()
    {
        const int target = 22;
        const int expectedIndex = -1;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayNotContainingTargetAtTheEnd_NotFound()
    {
        const int target = 40;
        const int expectedIndex = -1;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayContainingTargetAtTheEnd_FindsTarget()
    {
        const int target = 35;
        const int expectedIndex = 9;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }

    [Fact]
    public void JumpSearch_SortedArrayTargetZero_NotFound()
    {
        const int target = 0;
        const int expectedIndex = -1;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayTargetMinusFive_NotFound()
    {
        const int target = -5;
        const int expectedIndex = -1;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayNonExistingItemInFirstBlock_NotFound()
    {
        const int target = 2;
        const int expectedIndex = -1;
        int[] input = [1, 5, 6, 9, 11, 18, 20, 23, 24, 35];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
            
    [Fact]
    public void JumpSearch_SortedArrayWithTwoItems_FindsTarget()
    {
        const int target = 5;
        const int expectedIndex = 1;
        int[] input = [1, 5];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget()
    {
        const int target = 1;
        const int expectedIndex = 0;
        int[] input = [1, 5];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayWithOneItem_FindsTarget()
    {
        const int target = 5;
        const int expectedIndex = 0;
        int[] input = [5];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
     
    [Fact]
    public void JumpSearch_SortedArrayWithOneItemTargetBefore_NotFound()
    {
        const int target = 2;
        const int expectedIndex = -1;
        int[] input = [5];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
       
    [Fact]
    public void JumpSearch_SortedArrayWithOneItemTargetAfter_NotFound()
    {
        const int target = 22;
        const int expectedIndex = -1;
        int[] input = [5];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound()
    {
        const int target = 2;
        const int expectedIndex = -1;
        int[] input = [1, 5];

        var index = _searcher.Search(input, target);

        Assert.Equal(expectedIndex, index);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayContainingTarget_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTarget_FindsTarget(_searcher);
    }
    
    [Fact]
    public void JumpSearch_EmptyArray_ReturnsNegativeOne()
    {
        SharedSearchingTests.EmptyArray_ReturnsNegativeOne(_searcher);
    }
}