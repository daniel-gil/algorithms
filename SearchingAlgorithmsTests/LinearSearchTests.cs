using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class LinearSearchTests
{
    private readonly ISearcher _searcher = new LinearSearch();
    
    [Fact]
    public void LinearSearch_SortedArrayContainingTarget_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTarget_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_ArrayContainingTarget_FindsTarget()
    {
        SharedSearchingTests.RandomArrayContainingTarget_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_ArrayContainingTargetWithRepeats_FindsTarget()
    {
        SharedSearchingTests.RandomArrayContainingTargetWithRepeats_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_ArrayWithNegativeValuesContainingTarget_FindsTarget()
    {
        SharedSearchingTests.RandomArrayWithNegativeValuesContainingTarget_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_ArrayNotContainingTarget_ReturnsNegativeOne()
    {
        SharedSearchingTests.RandomArrayNotContainingTarget_ReturnsNegativeOne(_searcher);
    }
    
    [Fact]
    public void LinearSearch_EmptyArray_ReturnsNegativeOne()
    {
        SharedSearchingTests.EmptyArray_ReturnsNegativeOne(_searcher);
    }
    
    [Fact]
    public void LinearSearch_SortedArrayNotContainingTargetAtTheEnd_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTargetAtTheEnd_NotFound(_searcher);
    }
    
    [Fact]
    public void LinearSearch_SortedArrayContainingTargetAtTheEnd_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTargetAtTheEnd_FindsTarget(_searcher);
    }

    [Fact]
    public void LinearSearch_SortedArrayTargetZero_NotFound()
    {
        SharedSearchingTests.SortedArrayTargetZero_NotFound(_searcher);
    }
    
    [Fact]
    public void LinearSearch_SortedArrayNegativeTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNegativeTarget_NotFound(_searcher);
    }
            
    [Fact]
    public void LinearSearch_SortedArrayWithTwoItems_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtSecondPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_SortedArrayWithOneItem_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithOneItem_FindsTarget(_searcher);
    }
     
    [Fact]
    public void LinearSearch_SortedArrayWithOneItemTargetBefore_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetBefore_NotFound(_searcher);
    }
       
    [Fact]
    public void LinearSearch_SortedArrayWithOneItemTargetAfter_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetAfter_NotFound(_searcher);
    }
    
    [Fact]
    public void LinearSearch_SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound(_searcher);
    }
}