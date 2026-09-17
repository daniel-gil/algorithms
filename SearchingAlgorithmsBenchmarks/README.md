
## Running SearchingAlgorithms Benchmarks
```bash
cd /algorithms/SearchingAlgorithmsBenchmarks
dotnet run -c Release
```

### Results
```bash
| Method                | ArrayLength | Scenario  | Mean        | Error     | StdDev    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|---------------------- |------------ |---------- |------------:|----------:|----------:|------:|--------:|-----:|----------:|------------:|
| LinearSearch          | 10          | Beginning |   0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| ExponentialSearch     | 10          | Beginning |   0.5133 ns | 0.0037 ns | 0.0033 ns |     ? |       ? |    2 |         - |           ? |
| BinarySearchRecursive | 10          | Beginning |   0.7049 ns | 0.0130 ns | 0.0115 ns |     ? |       ? |    3 |         - |           ? |
| BinarySearchIterative | 10          | Beginning |   0.8380 ns | 0.0120 ns | 0.0107 ns |     ? |       ? |    4 |         - |           ? |
| TernarySearch         | 10          | Beginning |   0.8608 ns | 0.0048 ns | 0.0037 ns |     ? |       ? |    4 |         - |           ? |
| JumpSearch            | 10          | Beginning |   1.1071 ns | 0.0029 ns | 0.0026 ns |     ? |       ? |    5 |         - |           ? |
|                       |             |           |             |           |           |       |         |      |           |             |
| BinarySearchIterative | 10          | Middle    |   0.8124 ns | 0.0182 ns | 0.0170 ns |  0.64 |    0.01 |    1 |         - |          NA |
| BinarySearchRecursive | 10          | Middle    |   0.8653 ns | 0.0051 ns | 0.0046 ns |  0.68 |    0.01 |    2 |         - |          NA |
| TernarySearch         | 10          | Middle    |   1.0760 ns | 0.0063 ns | 0.0059 ns |  0.84 |    0.01 |    3 |         - |          NA |
| LinearSearch          | 10          | Middle    |   1.2749 ns | 0.0098 ns | 0.0082 ns |  1.00 |    0.01 |    4 |         - |          NA |
| JumpSearch            | 10          | Middle    |   1.5655 ns | 0.0129 ns | 0.0121 ns |  1.23 |    0.01 |    5 |         - |          NA |
| ExponentialSearch     | 10          | Middle    |   2.4015 ns | 0.0114 ns | 0.0101 ns |  1.88 |    0.01 |    6 |         - |          NA |
|                       |             |           |             |           |           |       |         |      |           |             |
| TernarySearch         | 10          | End       |   1.1301 ns | 0.0132 ns | 0.0117 ns |  0.53 |    0.01 |    1 |         - |          NA |
| BinarySearchRecursive | 10          | End       |   1.1524 ns | 0.0174 ns | 0.0163 ns |  0.54 |    0.01 |    1 |         - |          NA |
| BinarySearchIterative | 10          | End       |   1.2446 ns | 0.0344 ns | 0.0322 ns |  0.58 |    0.01 |    2 |         - |          NA |
| JumpSearch            | 10          | End       |   1.4733 ns | 0.0110 ns | 0.0097 ns |  0.69 |    0.01 |    3 |         - |          NA |
| LinearSearch          | 10          | End       |   2.1283 ns | 0.0122 ns | 0.0102 ns |  1.00 |    0.01 |    4 |         - |          NA |
| ExponentialSearch     | 10          | End       |   2.2125 ns | 0.0089 ns | 0.0070 ns |  1.04 |    0.01 |    5 |         - |          NA |
|                       |             |           |             |           |           |       |         |      |           |             |
| BinarySearchRecursive | 10          | Missing   |   0.8341 ns | 0.0212 ns | 0.0188 ns |  0.34 |    0.01 |    1 |         - |          NA |
| ExponentialSearch     | 10          | Missing   |   0.9016 ns | 0.0032 ns | 0.0027 ns |  0.36 |    0.00 |    2 |         - |          NA |
| TernarySearch         | 10          | Missing   |   1.0544 ns | 0.0419 ns | 0.0350 ns |  0.42 |    0.01 |    3 |         - |          NA |
| BinarySearchIterative | 10          | Missing   |   1.0873 ns | 0.0231 ns | 0.0216 ns |  0.44 |    0.01 |    3 |         - |          NA |
| JumpSearch            | 10          | Missing   |   1.2998 ns | 0.0116 ns | 0.0103 ns |  0.52 |    0.01 |    4 |         - |          NA |
| LinearSearch          | 10          | Missing   |   2.4860 ns | 0.0306 ns | 0.0286 ns |  1.00 |    0.02 |    5 |         - |          NA |
|                       |             |           |             |           |           |       |         |      |           |             |
| LinearSearch          | 100         | Beginning |   0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| ExponentialSearch     | 100         | Beginning |   0.5387 ns | 0.0091 ns | 0.0085 ns |     ? |       ? |    2 |         - |           ? |
| JumpSearch            | 100         | Beginning |   1.5290 ns | 0.0360 ns | 0.0319 ns |     ? |       ? |    3 |         - |           ? |
| BinarySearchRecursive | 100         | Beginning |   1.9181 ns | 0.0614 ns | 0.0754 ns |     ? |       ? |    4 |         - |           ? |
| BinarySearchIterative | 100         | Beginning |   1.9883 ns | 0.0351 ns | 0.0311 ns |     ? |       ? |    4 |         - |           ? |
| TernarySearch         | 100         | Beginning |   2.0058 ns | 0.0616 ns | 0.0734 ns |     ? |       ? |    4 |         - |           ? |
|                       |             |           |             |           |           |       |         |      |           |             |
| BinarySearchRecursive | 100         | Middle    |   1.8825 ns | 0.0190 ns | 0.0168 ns |  0.15 |    0.00 |    1 |         - |          NA |
| BinarySearchIterative | 100         | Middle    |   2.0239 ns | 0.0274 ns | 0.0257 ns |  0.16 |    0.00 |    2 |         - |          NA |
| TernarySearch         | 100         | Middle    |   2.2800 ns | 0.0217 ns | 0.0192 ns |  0.18 |    0.00 |    3 |         - |          NA |
| JumpSearch            | 100         | Middle    |   3.0591 ns | 0.0534 ns | 0.0499 ns |  0.25 |    0.01 |    4 |         - |          NA |
| ExponentialSearch     | 100         | Middle    |   3.2757 ns | 0.0469 ns | 0.0391 ns |  0.26 |    0.00 |    5 |         - |          NA |
| LinearSearch          | 100         | Middle    |  12.3851 ns | 0.2058 ns | 0.1824 ns |  1.00 |    0.02 |    6 |         - |          NA |
|                       |             |           |             |           |           |       |         |      |           |             |
| TernarySearch         | 100         | End       |   2.2950 ns | 0.0271 ns | 0.0254 ns |  0.07 |    0.00 |    1 |         - |          NA |
| BinarySearchRecursive | 100         | End       |   2.4742 ns | 0.0350 ns | 0.0310 ns |  0.08 |    0.00 |    2 |         - |          NA |
| BinarySearchIterative | 100         | End       |   2.7044 ns | 0.0773 ns | 0.0723 ns |  0.09 |    0.00 |    3 |         - |          NA |
| ExponentialSearch     | 100         | End       |   3.9785 ns | 0.0082 ns | 0.0068 ns |  0.13 |    0.00 |    4 |         - |          NA |
| JumpSearch            | 100         | End       |   5.5814 ns | 0.1006 ns | 0.0941 ns |  0.18 |    0.00 |    5 |         - |          NA |
| LinearSearch          | 100         | End       |  31.5117 ns | 0.4242 ns | 0.3968 ns |  1.00 |    0.02 |    6 |         - |          NA |
|                       |             |           |             |           |           |       |         |      |           |             |
| ExponentialSearch     | 100         | Missing   |   1.0094 ns | 0.0432 ns | 0.0790 ns |  0.03 |    0.00 |    1 |         - |          NA |
| JumpSearch            | 100         | Missing   |   1.5897 ns | 0.0184 ns | 0.0172 ns |  0.05 |    0.00 |    2 |         - |          NA |
| BinarySearchRecursive | 100         | Missing   |   1.9856 ns | 0.0117 ns | 0.0098 ns |  0.06 |    0.00 |    3 |         - |          NA |
| TernarySearch         | 100         | Missing   |   2.0898 ns | 0.0309 ns | 0.0274 ns |  0.07 |    0.00 |    4 |         - |          NA |
| BinarySearchIterative | 100         | Missing   |   2.1706 ns | 0.0356 ns | 0.0297 ns |  0.07 |    0.00 |    4 |         - |          NA |
| LinearSearch          | 100         | Missing   |  30.6046 ns | 0.2696 ns | 0.2522 ns |  1.00 |    0.01 |    5 |         - |          NA |
|                       |             |           |             |           |           |       |         |      |           |             |
| LinearSearch          | 1000        | Beginning |   0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| ExponentialSearch     | 1000        | Beginning |   0.5228 ns | 0.0025 ns | 0.0021 ns |     ? |       ? |    2 |         - |           ? |
| JumpSearch            | 1000        | Beginning |   2.2025 ns | 0.0117 ns | 0.0091 ns |     ? |       ? |    3 |         - |           ? |
| BinarySearchRecursive | 1000        | Beginning |   3.8861 ns | 0.0989 ns | 0.1139 ns |     ? |       ? |    4 |         - |           ? |
| BinarySearchIterative | 1000        | Beginning |   3.9520 ns | 0.0105 ns | 0.0098 ns |     ? |       ? |    4 |         - |           ? |
| TernarySearch         | 1000        | Beginning |   3.9709 ns | 0.0125 ns | 0.0117 ns |     ? |       ? |    4 |         - |           ? |
|                       |             |           |             |           |           |       |         |      |           |             |
| BinarySearchRecursive | 1000        | Middle    |   3.6929 ns | 0.0146 ns | 0.0122 ns |  0.03 |    0.00 |    1 |         - |          NA |
| ExponentialSearch     | 1000        | Middle    |   4.3295 ns | 0.0202 ns | 0.0158 ns |  0.04 |    0.00 |    2 |         - |          NA |
| BinarySearchIterative | 1000        | Middle    |   4.4039 ns | 0.0743 ns | 0.0695 ns |  0.04 |    0.00 |    2 |         - |          NA |
| TernarySearch         | 1000        | Middle    |   4.5227 ns | 0.1013 ns | 0.0948 ns |  0.04 |    0.00 |    2 |         - |          NA |
| JumpSearch            | 1000        | Middle    |   9.3027 ns | 0.1795 ns | 0.1591 ns |  0.08 |    0.00 |    3 |         - |          NA |
| LinearSearch          | 1000        | Middle    | 120.9032 ns | 0.2014 ns | 0.1786 ns |  1.00 |    0.00 |    4 |         - |          NA |
|                       |             |           |             |           |           |       |         |      |           |             |
| TernarySearch         | 1000        | End       |   4.1116 ns | 0.0192 ns | 0.0160 ns |  0.02 |    0.00 |    1 |         - |          NA |
| BinarySearchRecursive | 1000        | End       |   4.3708 ns | 0.0374 ns | 0.0312 ns |  0.02 |    0.00 |    2 |         - |          NA |
| BinarySearchIterative | 1000        | End       |   4.7640 ns | 0.0632 ns | 0.0591 ns |  0.02 |    0.00 |    3 |         - |          NA |
| ExponentialSearch     | 1000        | End       |   6.3282 ns | 0.0249 ns | 0.0221 ns |  0.03 |    0.00 |    4 |         - |          NA |
| JumpSearch            | 1000        | End       |  15.6131 ns | 0.1748 ns | 0.1635 ns |  0.07 |    0.00 |    5 |         - |          NA |
| LinearSearch          | 1000        | End       | 230.2572 ns | 0.2294 ns | 0.2145 ns |  1.00 |    0.00 |    6 |         - |          NA |
|                       |             |           |             |           |           |       |         |      |           |             |
| ExponentialSearch     | 1000        | Missing   |   0.9261 ns | 0.0192 ns | 0.0179 ns | 0.004 |    0.00 |    1 |         - |          NA |
| JumpSearch            | 1000        | Missing   |   2.3214 ns | 0.0230 ns | 0.0215 ns | 0.010 |    0.00 |    2 |         - |          NA |
| BinarySearchRecursive | 1000        | Missing   |   3.9288 ns | 0.0983 ns | 0.0966 ns | 0.017 |    0.00 |    3 |         - |          NA |
| TernarySearch         | 1000        | Missing   |   4.1308 ns | 0.0177 ns | 0.0157 ns | 0.018 |    0.00 |    3 |         - |          NA |
| BinarySearchIterative | 1000        | Missing   |   4.3469 ns | 0.0536 ns | 0.0502 ns | 0.019 |    0.00 |    4 |         - |          NA |
| LinearSearch          | 1000        | Missing   | 230.6330 ns | 1.4123 ns | 1.1794 ns | 1.000 |    0.01 |    5 |         - |          NA |
```
