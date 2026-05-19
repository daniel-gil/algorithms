using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class TernarySearchTests
{
    private readonly ISearcher _searcher = new TernarySearch();
    
    [Fact]
    public void TernarySearch_SortedArrayContainingTarget_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTarget_FindsTarget(_searcher);
    } 
    [Fact]
    public void TernarySearch_SortedArrayNotContainingTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTarget_NotFound(_searcher);
    }
    
    [Fact]
    public void LinearSearch_EmptyArray_ReturnsNegativeOne()
    {
        SharedSearchingTests.EmptyArray_ReturnsNegativeOne(_searcher);
    }
    
    [Fact]
    public void TernarySearch_SortedArrayNotContainingTargetAtTheEnd_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTargetAtTheEnd_NotFound(_searcher);
    }
    
    [Fact]
    public void TernarySearch_SortedArrayContainingTargetAtTheEnd_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTargetAtTheEnd_FindsTarget(_searcher);
    }

    [Fact]
    public void TernarySearch_SortedArrayTargetZero_NotFound()
    {
        SharedSearchingTests.SortedArrayTargetZero_NotFound(_searcher);
    }
    
    [Fact]
    public void TernarySearch_SortedArrayNegativeTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNegativeTarget_NotFound(_searcher);
    }
            
    [Fact]
    public void TernarySearch_SortedArrayWithTwoItems_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtSecondPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void TernarySearch_SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void TernarySearch_SortedArrayWithOneItem_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithOneItem_FindsTarget(_searcher);
    }
     
    [Fact]
    public void TernarySearch_SortedArrayWithOneItemTargetBefore_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetBefore_NotFound(_searcher);
    }
       
    [Fact]
    public void TernarySearch_SortedArrayWithOneItemTargetAfter_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetAfter_NotFound(_searcher);
    }
    
    [Fact]
    public void TernarySearch_SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound(_searcher);
    }
}