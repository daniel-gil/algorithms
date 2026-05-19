using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SearchingAlgorithms;
using SortingAlgorithms;

namespace SearchingAlgorithmsBenchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SearchingBenchmarks
{
    private const int TargetValue = 5;
    
    private readonly ISearcher _linearSearch = new LinearSearch();
    private readonly ISearcher _binarySearch = new BinarySearch();
    private readonly ISearcher _ternarySearch = new TernarySearch();
    private readonly ISearcher _jumpSearch = new JumpSearch();
    
    // Define parameters for different scenarios
    [Params(10, 100, 500)]
    public int ArrayLength;
    
    private int[] _randomArray;
    private int[] _sortedArray;
    
    // Run global setup once for each value of ArrayLength
    [GlobalSetup]
    public void GlobalSetup()
    {
        _randomArray = GenerateRandomArray(ArrayLength, TargetValue, ArrayLength/2); 
        _sortedArray = GenerateSortedArray(_randomArray); 
    }

    [Benchmark(Baseline = true)]
    public void LinearSearch()
    {
        _linearSearch.Search(_randomArray, TargetValue);
    }

    [Benchmark]
    public void BinarySearch()
    {
        _binarySearch.Search(_sortedArray, TargetValue);
    }

    [Benchmark]
    public void TernarySearch()
    {
        _ternarySearch.Search(_sortedArray, TargetValue);
    }

    [Benchmark]
    public void JumpSearch()
    {
        _jumpSearch.Search(_sortedArray, TargetValue);
    }
    
    private static int[] GenerateRandomArray(int length, int targetValue, int targetPosition)
    {
        var rand = new Random(Guid.NewGuid().GetHashCode());
        
        var randomArray = Enumerable.Range(0, length)
            .Select(_ => rand.Next())
            .ToArray();
        
        randomArray.Replace(targetValue, targetValue+1);
        randomArray[targetPosition] = targetValue;

        return randomArray;
    }
    
    private static int[] GenerateSortedArray(int[] array)
    {
        int[] copy = new int[array.Length];
        Array.Copy(array,copy, array.Length);
        
        var sorter = new QuickSort();
        sorter.Sort(copy);
        return copy;
    }
}