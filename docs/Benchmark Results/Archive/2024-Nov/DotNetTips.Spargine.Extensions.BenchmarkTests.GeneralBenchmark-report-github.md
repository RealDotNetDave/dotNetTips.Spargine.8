```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5011/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-QYBNOF : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Median | Min    | Q1     | Q3        | Max       | Op/s                | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|--------------- |----------:|----------:|----------:|----------:|-------:|-------:|-------:|----------:|----------:|--------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| &#39;Equals: Guid&#39; | 0.0006 ns | 0.0016 ns | 0.0013 ns | 0.0004 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0004 ns | 0.0048 ns | 1,753,202,003,567.0 |       6.500 ns |      13.00 |    7.488 |  2.222 |    2.348 |    1 | *            | No       |          - |                    - |                - |      42 B |         - |
