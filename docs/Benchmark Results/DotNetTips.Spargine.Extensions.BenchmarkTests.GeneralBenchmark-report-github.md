```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-JHXHAM : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Median    | Min    | Q1     | Q3        | Max       | Op/s              | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Exceptions | Code Size | Allocated |
|--------------- |----------:|----------:|----------:|----------:|----------:|-------:|-------:|----------:|----------:|------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|-----------:|----------:|----------:|
| &#39;Equals: Guid&#39; | 0.0031 ns | 0.0044 ns | 0.0039 ns | 0.0010 ns | 0.0008 ns | 0.0 ns | 0.0 ns | 0.0054 ns | 0.0126 ns | 322,745,445,910.6 |       6.999 ns |      14.00 |    2.802 |  2.250 |   0.9384 |    1 | *            | No       |                    - |                - |          - |      42 B |         - |
