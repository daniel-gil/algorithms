using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SearchingAlgorithms;

namespace SearchingAlgorithmsBenchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SearchingBenchmarks
{
    private const int TargetValue = 5;
    
    private readonly ISearcher _bubbleSort = new LinearSearch();
    
    // Define parameters for different scenarios
    [Params(10, 100, 1000)]
    public int ArrayLength;
    
    private int[] _array;

    
    // Run global setup once for each value of ArrayLength
    [GlobalSetup]
    public void GlobalSetup()
    {
        _array = GenerateRandomArray(ArrayLength, TargetValue, ArrayLength/2); 
    }

    [Benchmark(Baseline = true)]
    public void LinearSearch()
    {
        _bubbleSort.Search(_array, TargetValue);
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
}