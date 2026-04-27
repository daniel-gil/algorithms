using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SortingAlgorithms;

namespace SortingAlgorithmsBenchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SortingAlgorithmsBenchmarks
{
    private const int ArrayLength = 10000;
    private readonly int[] _input = new int[ArrayLength];

    private readonly ISorter _bubbleSort = new BubbleSort();

    public SortingAlgorithmsBenchmarks()
    {
        GenerateRandomArray();
    }

    private void GenerateRandomArray()
    {
        var rand = new Random(Guid.NewGuid().GetHashCode());
        for (var i = 0; i < ArrayLength; i++)
        {
            _input[i] = rand.Next(); 
        }
    }

    [Benchmark]
    public void BubbleSort() => _bubbleSort.Sort(_input);
}