```

BenchmarkDotNet v0.15.8, macOS Ventura 13.7.8 (22H730) [Darwin 22.6.0]
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method     | Mean     | Error     | StdDev    | Rank | Allocated |
|----------- |---------:|----------:|----------:|-----:|----------:|
| BubbleSort | 5.828 μs | 0.1152 μs | 0.2353 μs |    1 |         - |
