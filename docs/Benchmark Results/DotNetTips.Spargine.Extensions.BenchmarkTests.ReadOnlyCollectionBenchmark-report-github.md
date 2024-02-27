```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-QMVMBA : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

```
| Method           | Count | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|----------------- |------ |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|----------:|-----------:|----------:|
| DoesNotHaveItems | 16    |    113.6 ns |  0.57 ns |  0.47 ns |  0.13 ns |    112.9 ns |    113.3 ns |    113.7 ns |    113.8 ns |    114.7 ns | 8,801,349.3 |      0.5687 ns |      13.00 |    2.676 |  2.000 |   0.4193 |    1 | *            | No       | 0.0002 |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 32    |    256.3 ns | 16.53 ns | 48.73 ns |  4.87 ns |    208.3 ns |    209.8 ns |    246.6 ns |    295.0 ns |    400.8 ns | 3,902,175.6 |     16.5279 ns |     100.00 |    2.365 |  2.980 |   0.6451 |    2 | *            | No       | 0.0002 |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 64    |    385.2 ns |  3.39 ns |  3.01 ns |  0.80 ns |    381.2 ns |    383.0 ns |    384.6 ns |    387.6 ns |    391.5 ns | 2,595,905.3 |      3.3937 ns |      14.00 |    2.048 |  2.000 |   0.4813 |    3 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 128   |    672.0 ns |  1.60 ns |  1.34 ns |  0.37 ns |    670.0 ns |    671.0 ns |    671.5 ns |    672.9 ns |    674.7 ns | 1,488,147.1 |      1.6046 ns |      13.00 |    1.987 |  2.000 |   0.4475 |    4 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 256   |  1,383.3 ns |  8.63 ns |  8.07 ns |  2.08 ns |  1,372.9 ns |  1,377.1 ns |  1,383.0 ns |  1,387.7 ns |  1,401.6 ns |   722,907.3 |      8.6306 ns |      15.00 |    2.438 |  2.000 |   0.7076 |    5 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 512   |  2,861.6 ns | 11.15 ns |  9.31 ns |  2.58 ns |  2,845.2 ns |  2,855.6 ns |  2,864.4 ns |  2,869.1 ns |  2,875.5 ns |   349,458.1 |     11.1535 ns |      13.00 |    1.606 |  2.000 |  -0.1422 |    6 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 1024  |  5,431.2 ns | 23.46 ns | 21.95 ns |  5.67 ns |  5,400.4 ns |  5,417.6 ns |  5,423.1 ns |  5,443.1 ns |  5,478.4 ns |   184,122.1 |     23.4613 ns |      15.00 |    2.329 |  2.000 |   0.6806 |    7 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
| DoesNotHaveItems | 2048  | 11,329.5 ns | 58.25 ns | 54.49 ns | 14.07 ns | 11,243.9 ns | 11,280.3 ns | 11,338.0 ns | 11,374.1 ns | 11,407.1 ns |    88,265.0 |     58.2496 ns |      15.00 |    1.475 |  2.000 |  -0.2737 |    8 | *            | No       |      - |                    - |                - |     231 B |          - |      40 B |
