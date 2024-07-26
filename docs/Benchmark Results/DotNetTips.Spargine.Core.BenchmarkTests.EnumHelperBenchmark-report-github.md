```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  Job-MVKWPB : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

EvaluateOverhead=True  Runtime=.NET 8.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

```
| Method    | Mean       | Error   | StdDev  | StdErr  | Min        | Q1         | Median     | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Gen0   | Completed Work Items | Lock Contentions | Code Size | Exceptions | Allocated |
|---------- |-----------:|--------:|--------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |-------:|---------------------:|-----------------:|----------:|-----------:|----------:|
| GetValues | 1,277.0 ns | 5.78 ns | 5.40 ns | 1.40 ns | 1,268.3 ns | 1,271.5 ns | 1,276.8 ns | 1,281.2 ns | 1,284.4 ns | 783,080.1 |       5.778 ns |      15.00 |    1.422 |  2.000 |  -0.1381 |    1 | *            | No       | 0.0095 |                    - |                - |   1,959 B |          - |     904 B |
