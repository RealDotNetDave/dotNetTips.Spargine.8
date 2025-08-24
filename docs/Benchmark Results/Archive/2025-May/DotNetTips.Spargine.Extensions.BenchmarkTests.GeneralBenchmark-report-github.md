```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6093/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.302
  [Host]     : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Median | Min    | Q1     | Q3        | Max       | Op/s              | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|--------------- |----------:|----------:|----------:|----------:|-------:|-------:|-------:|----------:|----------:|------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|----------:|
| &#39;Equals: Guid&#39; | 0.0010 ns | 0.0017 ns | 0.0016 ns | 0.0004 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0015 ns | 0.0043 ns | 998,148,696,083.3 |       7.500 ns |      15.00 |    2.358 |  2.364 |    1.056 |    1 | *            | No       |      42 B |          - |                    - |                - |         - |
