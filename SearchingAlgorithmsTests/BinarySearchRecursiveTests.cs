using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class BinarySearchRecursiveTests
{
    private readonly ISearcher _searcher = new BinarySearchRecursive();
    
    [Fact]
    public void BinarySearchRecursive_WhenTargetIsLastRemainingElement_ShouldReturnItsIndex()
    {
        // Arrange
        var array = new[] { 1, 3, 5 };

        // Act
        var result = _searcher.Search(array, 1);

        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void BinarySearchRecursive_SortedArrayContainingTarget_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTarget_FindsTarget(_searcher);
    } 
    [Fact]
    public void BinarySearchRecursive_SortedArrayNotContainingTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTarget_NotFound(_searcher);
    }
    
    [Fact]
    public void LinearSearch_EmptyArray_ReturnsNegativeOne()
    {
        SharedSearchingTests.EmptyArray_ReturnsNegativeOne(_searcher);
    }
    
    [Fact]
    public void BinarySearchRecursive_SortedArrayNotContainingTargetAtTheEnd_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTargetAtTheEnd_NotFound(_searcher);
    }
    
    [Fact]
    public void BinarySearchRecursive_SortedArrayContainingTargetAtTheEnd_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTargetAtTheEnd_FindsTarget(_searcher);
    }

    [Fact]
    public void BinarySearchRecursive_SortedArrayTargetZero_NotFound()
    {
        SharedSearchingTests.SortedArrayTargetZero_NotFound(_searcher);
    }
    
    [Fact]
    public void BinarySearchRecursive_SortedArrayNegativeTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNegativeTarget_NotFound(_searcher);
    }
            
    [Fact]
    public void BinarySearchRecursive_SortedArrayWithTwoItems_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtSecondPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void BinarySearchRecursive_SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsTargetAtFirstPosition_FindsTarget(_searcher);
    }
    
    [Fact]
    public void BinarySearchRecursive_SortedArrayWithOneItem_FindsTarget()
    {
        SharedSearchingTests.SortedArrayWithOneItem_FindsTarget(_searcher);
    }
     
    [Fact]
    public void BinarySearchRecursive_SortedArrayWithOneItemTargetBefore_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetBefore_NotFound(_searcher);
    }
       
    [Fact]
    public void BinarySearchRecursive_SortedArrayWithOneItemTargetAfter_NotFound()
    {
        SharedSearchingTests.SortedArrayWithOneItemTargetAfter_NotFound(_searcher);
    }
    
    [Fact]
    public void BinarySearchRecursive_SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound()
    {
        SharedSearchingTests.SortedArrayWithTwoItemsNonExistingItemInFirstBlock_NotFound(_searcher);
    }
}