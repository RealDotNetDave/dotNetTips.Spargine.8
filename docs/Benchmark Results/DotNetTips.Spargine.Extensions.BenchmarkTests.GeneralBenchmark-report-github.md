```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.203
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  Job-WAULDK : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Min       | Q1        | Median    | Q3        | Max       | Op/s            | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Exceptions | Completed Work Items | Lock Contentions | Allocated |
|--------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-----------:|---------------------:|-----------------:|----------:|
| &#39;Equals: Guid&#39; | 0.2370 ns | 0.0090 ns | 0.0084 ns | 0.0022 ns | 0.2222 ns | 0.2317 ns | 0.2378 ns | 0.2437 ns | 0.2495 ns | 4,219,884,411.8 |       7.499 ns |      15.00 |    1.762 |  2.571 |  -0.2406 |    1 | *            | No       |      42 B |          - |                    - |                - |         - |
