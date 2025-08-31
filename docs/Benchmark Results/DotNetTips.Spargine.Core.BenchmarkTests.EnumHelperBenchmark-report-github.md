```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Gen0   | Code Size | Completed Work Items | Lock Contentions | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|-------:|----------:|---------------------:|-----------------:|----------:|
| GetValues | 1,204.1 ns | 7.42 ns | 6.94 ns | 1.79 ns | 1,194.7 ns | 1,198.2 ns | 1,204.9 ns | 1,210.0 ns | 1,214.8 ns | 830,495.5 |       6.604 ns |      15.00 |    1.431 |  2.000 |  -0.0124 |    1 | *            | No       |          - | 0.0076 |   1,889 B |                    - |                - |     840 B |
