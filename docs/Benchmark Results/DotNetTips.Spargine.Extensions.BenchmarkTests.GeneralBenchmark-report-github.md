```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.201
  [Host]     : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  Job-FRJBZZ : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=**FOR COMPARISON**  

```
| Method         | Mean      | Error     | StdDev    | StdErr    | Median | Min    | Q1     | Q3        | Max       | Op/s              | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|--------------- |----------:|----------:|----------:|----------:|-------:|-------:|-------:|----------:|----------:|------------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------------------:|-----------------:|----------:|-----------:|----------:|
| &#39;Equals: Guid&#39; | 0.0014 ns | 0.0030 ns | 0.0028 ns | 0.0007 ns | 0.0 ns | 0.0 ns | 0.0 ns | 0.0008 ns | 0.0091 ns | 724,535,185,518.4 |       7.500 ns |      15.00 |    4.522 |  2.182 |    1.717 |    1 | *            | No       |                    - |                - |      42 B |          - |         - |
