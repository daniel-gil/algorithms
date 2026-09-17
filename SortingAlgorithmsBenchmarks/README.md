## Running SortingAlgorithms Benchmarks
```bash
cd /algorithms/SortingAlgorithmsBenchmarks
dotnet run -c Release
```

### Results
```bash
| Method        | ArrayLength | Mean         | Error       | StdDev      | Ratio | Rank | Allocated | Alloc Ratio |
|-------------- |------------ |-------------:|------------:|------------:|------:|-----:|----------:|------------:|
| QuickSort     | 100         |     429.8 ns |     3.81 ns |     3.38 ns |  0.21 |    1 |         - |          NA |                                                                                                                 
| InsertionSort | 100         |     738.8 ns |     5.55 ns |     5.19 ns |  0.36 |    2 |         - |          NA |
| SelectionSort | 100         |   2,041.9 ns |    12.64 ns |    11.82 ns |  0.99 |    3 |         - |          NA |
| BubbleSort    | 100         |   2,069.1 ns |    21.27 ns |    18.85 ns |  1.00 |    3 |         - |          NA |
|               |             |              |             |             |       |      |           |             |
| QuickSort     | 1000        |   7,375.4 ns |    28.11 ns |    26.30 ns |  0.03 |    1 |         - |          NA |
| InsertionSort | 1000        |  68,201.6 ns | 1,229.15 ns | 1,207.19 ns |  0.27 |    2 |         - |          NA |
| SelectionSort | 1000        | 169,506.8 ns |   522.36 ns |   488.62 ns |  0.66 |    3 |         - |          NA |
| BubbleSort    | 1000        | 255,830.2 ns |   978.15 ns |   763.68 ns |  1.00 |    4 |         - |          NA |
```
