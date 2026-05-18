using SearchingAlgorithms;

namespace SearchingAlgorithmsTests;

public class BinarySearchTests
{
    private readonly ISearcher _searcher = new BinarySearch();
    
    [Fact]
    public void BinarySearch_SortedArrayContainingTarget_FindsTarget()
    {
        SharedSearchingTests.SortedArrayContainingTarget_FindsTarget(_searcher);
    } 
    [Fact]
    public void BinarySearch_SortedArrayNotContainingTarget_ReturnsMinusOne()
    {
        SharedSearchingTests.SortedArrayNotContainingTarget_ReturnsMinusOne(_searcher);
    }
    
    [Fact]
    public void LinearSearch_EmptyArray_ReturnsNegativeOne()
    {
        SharedSearchingTests.EmptyArray_ReturnsNegativeOne(_searcher);
    }
}