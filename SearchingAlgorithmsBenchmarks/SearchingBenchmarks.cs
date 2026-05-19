using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SearchingAlgorithms;

namespace SearchingAlgorithmsBenchmarks;

public enum SearchScenario
{
    Beginning,
    Middle,
    End,
    Missing
}

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SearchingBenchmarks
{
    private int _targetValue;
    
    private readonly ISearcher _linearSearch = new LinearSearch();
    private readonly ISearcher _binarySearchRecursive = new BinarySearchRecursive();
    private readonly ISearcher _binarySearchIterative = new BinarySearchIterative();
    private readonly ISearcher _ternarySearch = new TernarySearch();
    private readonly ISearcher _jumpSearch = new JumpSearch();
    private readonly ISearcher _exponentialSearch = new ExponentialSearch();
    
    // Define parameters for different scenarios
    [Params(10, 100, 1000)]
    public int ArrayLength;
    
    [Params(
        SearchScenario.Beginning,
        SearchScenario.Middle,
        SearchScenario.End,
        SearchScenario.Missing)]
    public SearchScenario Scenario;
    
    private int[] _sortedArray;
    
    // Run global setup once for each value of ArrayLength
    [GlobalSetup]
    public void GlobalSetup()
    {
        _sortedArray = ArrayGenerator.GenerateRandomSortedUniqueArray(ArrayLength);
       
        _targetValue = Scenario switch
        {
            SearchScenario.Beginning => _sortedArray[0],
            SearchScenario.Middle => _sortedArray[ArrayLength / 2],
            SearchScenario.End => _sortedArray[ArrayLength - 1],

            // guaranteed missing
            SearchScenario.Missing => -1,

            _ => throw new ArgumentOutOfRangeException()
        };
    }

    [Benchmark(Baseline = true)]
    public int LinearSearch()
    {
        return _linearSearch.Search(_sortedArray, _targetValue);
    }

    [Benchmark]
    public int BinarySearchRecursive()
    {
        return _binarySearchRecursive.Search(_sortedArray, _targetValue);
    }

    [Benchmark]
    public int BinarySearchIterative()
    {
        return _binarySearchIterative.Search(_sortedArray, _targetValue);
    }

    [Benchmark]
    public int TernarySearch()
    {
        return _ternarySearch.Search(_sortedArray, _targetValue);
    }

    [Benchmark]
    public int JumpSearch()
    {
        return _jumpSearch.Search(_sortedArray, _targetValue);
    }

    [Benchmark]
    public int ExponentialSearch()
    {
        return _exponentialSearch.Search(_sortedArray, _targetValue);
    }
}