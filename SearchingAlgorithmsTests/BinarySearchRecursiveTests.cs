using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class BinarySearchRecursiveTests
{
    private readonly ISearcher _searcher = new BinarySearchRecursive();
    
    [Fact]
    public void Search_WhenTargetIsLastRemainingElement_ShouldReturnItsIndex()
    {
        // Arrange
        var array = new[] { 1, 3, 5 };

        // Act
        var result = _searcher.Search(array, 1);

        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void BinarySearch_SortedArrayContainingTarget_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTarget_FindsTarget(_searcher);
    } 
    [Fact]
    public void BinarySearch_SortedArrayNotContainingTarget_NotFound()
    {
        SharedSearchingTests.SortedArrayNotContainingTarget_NotFound(_searcher);
    }
    
    [Fact]
    public void LinearSearch_EmptyArray_ReturnsNegativeOne()
    {
        SharedSearchingTests.EmptyArray_ReturnsNegativeOne(_searcher);
    }
}