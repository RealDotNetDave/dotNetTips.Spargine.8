```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300-preview.24203.14
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-XJVIUY : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Median | Min    | Q1     | Q3     | Max       | Op/s                | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Completed Work Items | Lock Contentions | Code Size | Allocated |
|--------------- |----------:|----------:|----------:|----------:|-------:|-------:|-------:|-------:|----------:|--------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|---------------------:|-----------------:|----------:|----------:|
| &#39;Equals: Guid&#39; | 0.0004 ns | 0.0012 ns | 0.0011 ns | 0.0003 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0035 ns | 2,366,112,437,197.0 |      0.0012 ns |      15.00 |    5.196 |  2.000 |    1.990 |    1 | *            | No       |          - |                    - |                - |      42 B |         - |
