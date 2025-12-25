```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Min       | Q1        | Median    | Q3        | Max       | Op/s            | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|--------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|----------:|
| &#39;Equals: Guid&#39; | 0.2717 ns | 0.0147 ns | 0.0137 ns | 0.0035 ns | 0.2395 ns | 0.2638 ns | 0.2739 ns | 0.2821 ns | 0.2876 ns | 3,680,142,141.1 |       7.498 ns |      15.00 |    2.668 |  2.222 |  -0.7062 |    1 | *            | No       |      42 B |          - |                    - |                - |         - |
