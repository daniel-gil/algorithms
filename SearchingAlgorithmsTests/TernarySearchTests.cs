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
}