```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-ZSORKR : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean   | Error  | StdErr | StdDev | Min    | Q1     | Median | Q3     | Max    | Op/s     | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|--------------- |-------:|-------:|-------:|-------:|-------:|-------:|-------:|-------:|-------:|---------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|----------:|
| &#39;Equals: Guid&#39; | 0.0 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0 ns | Infinity |         0.0 ns |      13.00 |       NA |  2.000 |       NA |    1 | *            | No       |      42 B |          - |                    - |                - |         - |
