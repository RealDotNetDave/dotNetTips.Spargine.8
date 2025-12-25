```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6691/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.308
  [Host]     : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
  Job-ZSLFFS : .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Min    | Q1        | Median    | Q3        | Max       | Op/s              | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|--------------- |----------:|----------:|----------:|----------:|-------:|----------:|----------:|----------:|----------:|------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|----------:|-----------:|----------:|
| &#39;Equals: Guid&#39; | 0.0051 ns | 0.0055 ns | 0.0049 ns | 0.0013 ns | 0.0 ns | 0.0003 ns | 0.0047 ns | 0.0072 ns | 0.0164 ns | 196,782,669,326.7 |       6.999 ns |      14.00 |    2.672 |  2.000 |   0.7430 |    1 | *            | No       |                    - |                - |      42 B |          - |         - |
