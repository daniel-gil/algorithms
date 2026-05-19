using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class ExponentialSearchTests
{
    private readonly ISearcher _searcher = new ExponentialSearch();
  
    [Fact]
    public void ExponentialSearch_SortedArrayNotContainingTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTarget_NotFound(_searcher);
    }
    
    [Fact]
    public void ExponentialSearch_SortedArrayContainingTarget_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTarget_FindsTarget(_searcher);
    }
    
    [Fact]
    public void ExponentialSearch_EmptyArray_ReturnsNegativeOne()
    {
        SharedSearchingTests.EmptyArray_ReturnsNegativeOne(_searcher);
    }
    
    [Fact]
    public void ExponentialSearch_SortedArrayNotContainingTargetAtTheEnd_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTargetAtTheEnd_NotFound(_searcher);
    }
    
    [Fact]
    public void ExponentialSearch_SortedArrayContainingTargetAtTheEnd_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTargetAtTheEnd_FindsTarget(_searcher);
    }

    [Fact]
    public void ExponentialSearch_SortedArrayTargetZero_NotFound()
    {
        SharedSearchingTests.SortedArrayTargetZero_NotFound(_searcher);
    }
    
    [Fact]
    public void ExponentialSearch_SortedArrayNegativeTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNegativeTarget_NotFound(_searcher);
    }
            
    [Fact]
    public void ExponentialSearch_SortedArrayWithTwoItems_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtSecondPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void ExponentialSearch_SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void ExponentialSearch_SortedArrayWithOneItem_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithOneItem_FindsTarget(_searcher);
    }
     
    [Fact]
    public void ExponentialSearch_SortedArrayWithOneItemTargetBefore_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetBefore_NotFound(_searcher);
    }
       
    [Fact]
    public void ExponentialSearch_SortedArrayWithOneItemTargetAfter_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetAfter_NotFound(_searcher);
    }
    
    [Fact]
    public void ExponentialSearch_SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound(_searcher);
    }
}

