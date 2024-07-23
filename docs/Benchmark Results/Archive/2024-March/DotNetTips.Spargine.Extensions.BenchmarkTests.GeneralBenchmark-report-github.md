```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  Job-TLMPGC : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Median    | Min    | Q1     | Q3        | Max       | Op/s              | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|--------------- |----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|----------:|------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| &#39;Equals: Guid&#39; | 0.0033 ns | 0.0047 ns | 0.0044 ns | 0.0011 ns | 0.0013 ns | 0.0 ns | 0.0 ns | 0.0048 ns | 0.0125 ns | 299,382,639,438.8 |      0.0047 ns |      15.00 |    2.667 |  2.000 |    1.061 |    1 | *            | No       |          - |                    - |                - |      42 B |         - |
