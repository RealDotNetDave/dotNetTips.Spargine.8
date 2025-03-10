```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  Job-THQNBF : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|----------:|-----------:|----------:|
| GetValues | 1,212.5 ns | 8.00 ns | 7.48 ns | 1.93 ns | 1,200.2 ns | 1,207.5 ns | 1,211.0 ns | 1,219.5 ns | 1,222.3 ns | 824,773.9 |       6.534 ns |      15.00 |    1.574 |  2.000 |  -0.1021 |    1 | *            | No       | 0.0076 |                    - |                - |   1,889 B |          - |     840 B |
