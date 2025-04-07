```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-QFNFJQ : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Min       | Q1        | Median    | Q3        | Max       | Op/s            | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Exceptions | Code Size | Completed Work Items | Lock Contentions | Allocated |
|--------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------:|----------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-----------:|----------:|---------------------:|-----------------:|----------:|
| &#39;Equals: Guid&#39; | 0.2382 ns | 0.0043 ns | 0.0038 ns | 0.0010 ns | 0.2301 ns | 0.2367 ns | 0.2389 ns | 0.2404 ns | 0.2449 ns | 4,198,261,189.2 |       6.999 ns |      14.00 |    2.692 |  2.000 |  -0.4908 |    1 | *            | No       |          - |      42 B |                    - |                - |         - |
