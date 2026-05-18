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
        SharedSearchingTests.ArrayContainingTarget_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_ArrayContainingTargetWithRepeats_FindsTarget()
    {
        SharedSearchingTests.ArrayContainingTargetWithRepeats_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_ArrayWithNegativeValuesContainingTarget_FindsTarget()
    {
        SharedSearchingTests.ArrayWithNegativeValuesContainingTarget_FindsTarget(_searcher);
    }
    
    [Fact]
    public void LinearSearch_ArrayNotContainingTarget_ReturnsNegativeOne()
    {
        SharedSearchingTests.ArrayNotContainingTarget_ReturnsNegativeOne(_searcher);
    }
    
    [Fact]
    public void LinearSearch_EmptyArray_ReturnsNegativeOne()
    {
        SharedSearchingTests.EmptyArray_ReturnsNegativeOne(_searcher);
    }
}