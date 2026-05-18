using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<SortingAlgorithmsBenchmarks.SortingBenchmarks>();
