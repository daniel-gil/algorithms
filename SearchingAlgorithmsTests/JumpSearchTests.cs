using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class JumpSearchTests
{
    private readonly ISearcher _searcher = new JumpSearch();
    
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
    public void JumpSearch_SortedArrayNotContainingTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTarget_NotFound(_searcher);
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
    
    [Fact]
    public void JumpSearch_SortedArrayNotContainingTargetAtTheEnd_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTargetAtTheEnd_NotFound(_searcher);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayContainingTargetAtTheEnd_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTargetAtTheEnd_FindsTarget(_searcher);
    }

    [Fact]
    public void JumpSearch_SortedArrayTargetZero_NotFound()
    {
        SharedSearchingTests.SortedArrayTargetZero_NotFound(_searcher);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayNegativeTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNegativeTarget_NotFound(_searcher);
    }
            
    [Fact]
    public void JumpSearch_SortedArrayWithTwoItems_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtSecondPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayWithOneItem_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithOneItem_FindsTarget(_searcher);
    }
     
    [Fact]
    public void JumpSearch_SortedArrayWithOneItemTargetBefore_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetBefore_NotFound(_searcher);
    }
       
    [Fact]
    public void JumpSearch_SortedArrayWithOneItemTargetAfter_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetAfter_NotFound(_searcher);
    }
    
    [Fact]
    public void JumpSearch_SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound(_searcher);
    }
}