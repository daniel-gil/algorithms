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
}