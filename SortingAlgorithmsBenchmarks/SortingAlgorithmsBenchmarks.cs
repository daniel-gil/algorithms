using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SortingAlgorithms;

namespace SortingAlgorithmsBenchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SortingAlgorithmsBenchmarks
{
    // Define parameters for different scenarios
    [Params(100, 1000, 5000)]
    public int ArrayLength;
    
    private int[] _original;   // original input
    private int[] _working;    // buffer used for sorting

    private readonly ISorter _bubbleSort = new BubbleSort();
    private readonly ISorter _selectionSort = new SelectionSort();
    
    // Run global setup once for each value of ArrayLength
    [GlobalSetup]
    public void GlobalSetup()
    {
        _original = GenerateRandomArray(ArrayLength); 
        _working = new int[ArrayLength];
    }
    
    [Benchmark(Baseline = true)]
    public void BubbleSort()
    {
        Array.Copy(_original, _working, ArrayLength);
        _bubbleSort.Sort(_working);
    }

    [Benchmark]
    public void SelectionSort()
    {
        Array.Copy(_original, _working, ArrayLength);
        _selectionSort.Sort(_working);
    }
    
    private static int[] GenerateRandomArray(int length)
    {
        var rand = new Random(Guid.NewGuid().GetHashCode());
        
        var randomArray = Enumerable.Range(0, length)
            .Select(_ => rand.Next())
            .ToArray();

        return randomArray;
    }
}